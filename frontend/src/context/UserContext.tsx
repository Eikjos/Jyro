import { auth, login as loginRequest, logout as logoutRequest } from '../api/auth';
import { JWTCOOKIE, User } from '../types/User';
import { UserContextType } from '../types/UserContextType';
import Cookies from 'js-cookie';
import { ReactNode, createContext, useContext, useState } from 'react';
import { useMutation, useQuery } from 'react-query';

const UserContext = createContext<UserContextType | null>(null);

const UserContextProvider = ({ children }: { children: ReactNode }) => {
  const [user, setUser] = useState<User>();

  const setToken = (token: string) =>
    Cookies.set(JWTCOOKIE, token, {
      secure: true,
      expires: new Date().setDate(new Date().getDate() + 7),
      sameSite: 'strict',
    });
  const getToken = () => Cookies.get(JWTCOOKIE) ?? '';

  const mutationLogin = useMutation({
    mutationFn: loginRequest,
  });

  const mutationLogout = useMutation({
    mutationFn: () => logoutRequest(getToken()),
    onSuccess: () => {
      Cookies.remove(JWTCOOKIE);
      setUser(undefined);
    },
  });

  useQuery({
    queryFn: () => auth(getToken()),
    queryKey: ['user', '@me'],
    onSuccess: (data) => {
      setUser(data.user);
      setToken(data.token);
    },
    onError: () => {
      setUser(undefined);
      Cookies.remove(JWTCOOKIE);
    },
  });

  const login = (email: string, password: string, onSuccess: () => void) => {
    mutationLogin.mutate(
      { email, password },
      {
        onSuccess: (data) => {
          setToken(data.token);
          setUser(data.user);
          console.log(data.token);
          onSuccess();
        },
      },
    );
  };

  const logout = () => {
    mutationLogout.mutate();
  };

  const value: UserContextType = {
    user: user,
    login: login,
    logout: logout,
    getToken: getToken,
  };

  return <UserContext.Provider value={value}>{children}</UserContext.Provider>;
};

const useUserContext = () => {
  const context = useContext(UserContext);

  if (context === null) {
    throw Error("Le UserContext n'est pas initialisé.");
  }

  return context;
};

export { useUserContext, UserContextProvider, UserContext };

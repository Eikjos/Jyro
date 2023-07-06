import {
  ReactNode,
  createContext,
  useContext,
  useEffect,
  useState,
} from "react";
import { User } from "../types/User";
import { UserContextType } from "../types/UserContextType";
import Cookies from "js-cookie";
import {
  auth,
  login as loginRequest,
  logout as logoutRequest,
} from "../api/auth";
import { useQueryClient, useQuery, useMutation } from "react-query";

const UserContext = createContext<UserContextType | null>(null);

const UserContextProvider = ({ children }: { children: ReactNode }) => {
  const [user, setUser] = useState<User>();
  const [token, setToken] = useState<string>();

  const authentication = useQuery({
    queryFn: () => auth(token!),
    queryKey: ["user", "@me"],
  });

  const mutationLogin = useMutation({
    mutationFn: loginRequest,
    onSuccess: (data) => {
      setToken(data.token);
      setUser(data.user);
    },
  });

  const mutationLogout = useMutation({
    mutationFn: () => logoutRequest(token!),
    onSuccess: () => {
      setToken(undefined);
      setUser(undefined);
    },
  });

  useEffect(() => {
    const token = Cookies.get("token");
    if (token) {
      if (authentication.isError) {
        setToken(undefined);
      } else {
        setUser(authentication.data?.user);
        setToken(authentication.data?.token);
      }
    }
  }, []);

  const login = (email: string, password: string) => {
    mutationLogin.mutate({ email: email, passowrd: password });
  };

  const logout = () => {
    mutationLogout.mutate();
  };

  const value: UserContextType = {
    user: user,
    login: login,
    logout: logout,
    token: token,
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

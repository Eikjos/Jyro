import { User } from './User';

export type UserContextType = {
  isLoaging: boolean;
  user: User | undefined;
  getToken: () => string | null;
  login: (email: string, password: string, onSuccess: () => void) => void;
  logout: () => void;
};

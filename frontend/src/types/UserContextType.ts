import { User } from "./User";

export type UserContextType = {
  user: User | undefined;
  token: string | undefined;
  login: (email: string, password: string) => void;
  logout: () => void;
};
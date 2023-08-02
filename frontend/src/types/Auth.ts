import { User } from "./User";

export type Auth = {
  user: User;
  token: string;
};

export type LoginRequestType = {
  email: string;
  password: string;
};

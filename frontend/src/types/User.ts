export type User = {
  id: string;
  firstname: string;
  lastname: string;
};

export type RegisterRequestType = {
  firstname: string;
  lastname: string;
  email: string;
  password: string;
};

export const JWTCOOKIE = 'token';

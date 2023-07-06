import { client } from "./client";
import { Auth } from "../types/Auth";

export const auth = (token: string) =>
  client
    .get<Auth>("authentification/auth", {
      headers: { Authorization: token },
    })
    .then((r) => r.data);

export const login = (json: { email: string; passowrd: string }) =>
  client.post<Auth>("authentification/login", { json }, {}).then((r) => r.data);

export const logout = (token: string) =>
  client
    .post("/authentication/logout", {
      headers: { getAuthorization: token },
    })
    .then((r) => null);

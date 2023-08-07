import { client } from "./client";
import { Auth, LoginRequestType } from "../types/Auth";

export const auth = (token: string) =>
  client
    .get<Auth>("authentication/auth", {
      headers: { Authorization: "Bearer " + token },
    })
    .then((r) => r.data);

export const login = (json: LoginRequestType) =>
  client.post<Auth>("authentication/login", json).then((r) => r.data);

export const logout = (token: string) =>
  client
    .post("authentication/logout", {
      headers: { getAuthorization: token },
    })
    .then((r) => null);

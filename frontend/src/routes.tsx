import { RouteObject } from "react-router-dom";
import { HomePage, LoginPage } from "./components";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <HomePage />,
  },
  {
    path: "/login",
    element: <LoginPage />,
  },
];

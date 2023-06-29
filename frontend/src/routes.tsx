import { RouteObject } from "react-router-dom";
import { HomePage } from "./components";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <HomePage />,
  },
];

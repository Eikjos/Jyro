import { Outlet, RouterProvider, createBrowserRouter } from "react-router-dom";
import { QueryClient, QueryClientProvider } from "react-query";
import { routes } from "./routes";
import { UserContextProvider } from "./context/UserContext";
import { ChakraProvider } from "@chakra-ui/react";

const router = createBrowserRouter(routes);
const queryClient = new QueryClient({
  defaultOptions: {
    queries: {
      retry: false,
      refetchOnWindowFocus: false,
    },
  },
});

export default function App() {
  return (
    <ChakraProvider>
      <QueryClientProvider client={queryClient}>
        <UserContextProvider>
          <RouterProvider router={router} />
        </UserContextProvider>
      </QueryClientProvider>
    </ChakraProvider>
  );
}

import { HomePage, LoginPage, ProjectListPage, RegisterPage } from '@components';
import { RouteObject } from 'react-router-dom';

export const routes: RouteObject[] = [
  {
    path: '/',
    element: <HomePage />,
  },
  {
    path: '/login',
    element: <LoginPage />,
  },
  {
    path: '/register',
    element: <RegisterPage />,
  },
  {
    path: '/projects',
    element: <ProjectListPage />,
  },
];

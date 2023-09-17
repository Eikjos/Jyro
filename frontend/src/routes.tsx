import { AuthenticatedGuard } from './guards/AuthenticatedGuard';
import { HomePage, LoginPage, ProjectListPage, RegisterPage } from '@components';
import { RouteObject } from 'react-router-dom';

export const routes: RouteObject[] = [
  {
    path: '/',
    element: (
      <AuthenticatedGuard>
        <HomePage />
      </AuthenticatedGuard>
    ),
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
    element: (
      <AuthenticatedGuard>
        <ProjectListPage />
      </AuthenticatedGuard>
    ),
  },
];

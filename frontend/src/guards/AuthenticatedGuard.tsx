import { useUserContext } from '@context/UserContext';
import { Navigate } from 'react-router-dom';

export function AuthenticatedGuard({ children }: { children: React.ReactNode }) {
  const { user, isLoaging } = useUserContext();
  if (isLoaging) return null;
  return user ? <>{children}</> : <Navigate to="login" replace />;
}

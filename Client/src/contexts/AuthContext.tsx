import { createContext, useContext, useEffect, useState } from 'react';
import type { ReactNode } from 'react';
import { logout as authLogout, isAuthenticated as checkAuth, getUserRoles, isAdmin, hasRole } from '../utils/authService';

interface AuthContextType {
  isAuthenticated: boolean;
  isLoading: boolean;
  userRoles: string[];
  isAdmin: boolean;
  hasRole: (roleName: string) => boolean;
  login: (token: string) => void;
  logout: () => void;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (context === undefined) {
    throw new Error('useAuth must be used within an AuthProvider');
  }
  return context;
};

// Custom hooks for common role checks
export const useHasRole = (roleName: string): boolean => {
  const { hasRole } = useAuth();
  return hasRole(roleName);
};

export const useIsAdmin = (): boolean => {
  const { isAdmin } = useAuth();
  return isAdmin;
};

interface AuthProviderProps {
  children: ReactNode;
}

export const AuthProvider = ({ children }: AuthProviderProps) => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isLoading, setIsLoading] = useState(true);
  const [userRoles, setUserRoles] = useState<string[]>([]);
  const [isAdminUser, setIsAdminUser] = useState(false);

  // Check authentication status on mount and when localStorage changes
  useEffect(() => {
    const checkAuthStatus = () => {
      const authenticated = checkAuth(); // Use the improved authentication check
      setIsAuthenticated(authenticated);
      
      if (authenticated) {
        const roles = getUserRoles();
        const adminStatus = isAdmin();
        setUserRoles(roles);
        setIsAdminUser(adminStatus);
      } else {
        setUserRoles([]);
        setIsAdminUser(false);
      }
      
      setIsLoading(false);
    };

    checkAuthStatus();

    // Listen for storage changes (e.g., token added/removed in another tab)
    const handleStorageChange = (e: StorageEvent) => {
      if (e.key === 'token') {
        checkAuthStatus();
      }
    };

    window.addEventListener('storage', handleStorageChange);

    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);

  const login = (token: string) => {
    localStorage.setItem('token', token);
    setIsAuthenticated(true);
    
    // Update role information after login
    const roles = getUserRoles();
    const adminStatus = isAdmin();
    setUserRoles(roles);
    setIsAdminUser(adminStatus);
  };

  const logout = () => {
    authLogout(); // Call the existing logout function
    setIsAuthenticated(false);
    setUserRoles([]);
    setIsAdminUser(false);
  };

  const value = {
    isAuthenticated,
    isLoading,
    userRoles,
    isAdmin: isAdminUser,
    hasRole,
    login,
    logout,
  };

  return (
    <AuthContext.Provider value={value}>
      {children}
    </AuthContext.Provider>
  );
};

export default AuthProvider;

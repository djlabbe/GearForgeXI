import { createContext, useContext, useEffect, useState } from 'react';
import type { ReactNode } from 'react';
import { logout as authLogout, isAuthenticated as checkAuth } from '../utils/authService';

interface AuthContextType {
  isAuthenticated: boolean;
  isLoading: boolean;
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

interface AuthProviderProps {
  children: ReactNode;
}

export const AuthProvider = ({ children }: AuthProviderProps) => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [isLoading, setIsLoading] = useState(true);

  // Check authentication status on mount and when localStorage changes
  useEffect(() => {
    const checkAuthStatus = () => {
      const authenticated = checkAuth(); // Use the improved authentication check
      setIsAuthenticated(authenticated);
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
  };

  const logout = () => {
    authLogout(); // Call the existing logout function
    setIsAuthenticated(false);
  };

  const value = {
    isAuthenticated,
    isLoading,
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

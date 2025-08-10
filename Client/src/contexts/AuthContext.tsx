import { createContext, useContext, useEffect, useState } from 'react';
import type { ReactNode } from 'react';
import { logout as authLogout, isAuthenticated as checkAuth, getUserRoles, isAdmin, hasRole } from '../utils/authService';
import TokenManager from '../utils/tokenManager';

interface AuthContextType {
  isAuthenticated: boolean;
  isLoading: boolean;
  userRoles: string[];
  isAdmin: boolean;
  hasRole: (roleName: string) => boolean;
  login: () => void;
  logout: () => Promise<void>;
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
    const checkAuthStatus = async () => {
      setIsLoading(true);
      
      // First, try to refresh tokens if they exist but are expired
      if (TokenManager.hasValidTokens() && TokenManager.isTokenExpired()) {
        try {
          await TokenManager.refreshAccessToken();
        } catch (error) {
          console.error('Token refresh failed during initialization:', error);
        }
      }
      
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
      
      // Small delay to prevent loading flash for very quick operations
      await new Promise(resolve => setTimeout(resolve, 100));
      setIsLoading(false);
    };

    checkAuthStatus();

    // Listen for storage changes (e.g., token added/removed in another tab)
    const handleStorageChange = (e: StorageEvent) => {
      if (e.key === 'access_token' || e.key === 'refresh_token') {
        checkAuthStatus();
      }
    };

    // Set up periodic token refresh check (every 5 minutes)
    const refreshInterval = setInterval(async () => {
      if (TokenManager.hasValidTokens() && TokenManager.isTokenExpired()) {
        await TokenManager.refreshAccessToken();
        // Update auth state after refresh
        const authenticated = checkAuth();
        setIsAuthenticated(authenticated);
        if (authenticated) {
          const roles = getUserRoles();
          const adminStatus = isAdmin();
          setUserRoles(roles);
          setIsAdminUser(adminStatus);
        }
      }
    }, 5 * 60 * 1000); // 5 minutes

    window.addEventListener('storage', handleStorageChange);

    return () => {
      window.removeEventListener('storage', handleStorageChange);
      clearInterval(refreshInterval);
    };
  }, []);

  const login = () => {
    // The login logic is now handled by the authService login function
    // This function just updates the local state after successful login
    setIsAuthenticated(true);
    
    // Update role information after login
    const roles = getUserRoles();
    const adminStatus = isAdmin();
    setUserRoles(roles);
    setIsAdminUser(adminStatus);
  };

  const logout = async () => {
    await authLogout(); // Call the updated logout function that revokes tokens
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

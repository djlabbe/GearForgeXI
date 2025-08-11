import { useEffect, useCallback } from 'react';
import TokenManager from '../utils/tokenManager';
import { useAuth } from '../contexts/AuthContext';

/**
 * Hook that sets up automatic token refresh
 * This ensures tokens are refreshed before they expire
 */
export function useTokenRefresh() {
  const { logout } = useAuth();

  const checkAndRefreshToken = useCallback(async () => {
    try {
      // If token is expired or will expire soon, refresh it
      if (TokenManager.isTokenExpired()) {
        const refreshed = await TokenManager.refreshAccessToken();
        if (!refreshed) {
          // If refresh failed, log the user out
          await logout();
        }
      }
    } catch (error) {
      console.error('Error during token refresh:', error);
      await logout();
    }
  }, [logout]);

  useEffect(() => {
    // Check token immediately
    checkAndRefreshToken();

    // Set up interval to check token every 2 minutes for more aggressive refresh
    const interval = setInterval(checkAndRefreshToken, 2 * 60 * 1000);

    return () => clearInterval(interval);
  }, [checkAndRefreshToken]);
}

/**
 * Hook that provides token-related utilities
 */
export function useTokens() {
  return {
    getValidToken: TokenManager.getValidAccessToken.bind(TokenManager),
    isTokenExpired: TokenManager.isTokenExpired.bind(TokenManager),
    hasValidTokens: TokenManager.hasValidTokens.bind(TokenManager),
    refreshToken: TokenManager.refreshAccessToken.bind(TokenManager),
  };
}

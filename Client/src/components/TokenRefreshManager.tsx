import { useTokenRefresh } from "../hooks/useTokens";

/**
 * Component that handles automatic token refresh
 * Should be placed inside the AuthProvider but outside the Router
 */
export function TokenRefreshManager() {
  useTokenRefresh();
  return null; // This component doesn't render anything
}

export default TokenRefreshManager;

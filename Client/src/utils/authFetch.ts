import TokenManager from "./tokenManager";

export async function authFetch(input: RequestInfo, init: RequestInit = {}): Promise<Response> {
  // First, try to get a valid token
  let token = TokenManager.getAccessToken();
  
  // If no token or token is expired, try to refresh
  if (!token || TokenManager.isTokenExpired()) {
    const refreshed = await TokenManager.refreshAccessToken();
    if (!refreshed) {
      throw new Error('Authentication required');
    }
    token = TokenManager.getAccessToken();
  }

  if (!token) {
    throw new Error('Authentication required');
  }

  const headers = {
    ...(init.headers || {}),
    Authorization: `Bearer ${token}`,
  };

  const response = await fetch(input, { ...init, headers });

  // If we get a 401, try to refresh the token once more
  if (response.status === 401) {
    const refreshed = await TokenManager.refreshAccessToken();
    if (refreshed) {
      const newToken = TokenManager.getAccessToken();
      if (newToken) {
        const retryHeaders = {
          ...(init.headers || {}),
          Authorization: `Bearer ${newToken}`,
        };
        return fetch(input, { ...init, headers: retryHeaders });
      }
    }
    
    // If refresh failed, clear tokens and throw error
    TokenManager.clearTokens();
    throw new Error('Authentication expired');
  }

  return response;
}

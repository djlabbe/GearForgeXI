import TokenManager, { type TokenResponse } from './tokenManager';

const API_BASE = "/api";

export async function login(email: string, password: string) {
  const response = await fetch(`${API_BASE}/account/login`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ email, password }),
  });

  if (!response.ok) {
    throw new Error("Login failed");
  }

  const data: TokenResponse = await response.json();
  TokenManager.saveTokens(data);
  return data.accessToken;
}

export async function register(email: string, password: string, confirmPassword: string) {
  if (password !== confirmPassword) {
    throw new Error("Passwords do not match");
  }

  const response = await fetch(`${API_BASE}/account/register`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ email, password }),
  });

  if (!response.ok) {
    const errorData = await response.json().catch(() => ({ message: "Registration failed" }));
    throw new Error(errorData.message || "Registration failed");
  }

  const data: TokenResponse = await response.json();
  TokenManager.saveTokens(data);
  return data.accessToken;
}

export async function logout() {
  await TokenManager.revokeRefreshToken();
  TokenManager.clearTokens();
}

export function getToken(): string | null {
  // Return access token
  return TokenManager.getAccessToken();
}

export async function getValidToken(): Promise<string | null> {
  return await TokenManager.getValidAccessToken();
}

export function getUserRoles(): string[] {
  const token = getToken();
  if (!token) return [];
  
  try {
    const payload = JSON.parse(atob(token.split('.')[1]));
    // JWT tokens typically store roles in 'role', 'roles', or a custom claim
    const roles = payload.role || payload.roles || payload['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'] || [];
    
    // Always return an array - convert single string to array if needed
    return Array.isArray(roles) ? roles : [roles];
  } catch (error) {
    return [];
  }
}

export function hasRole(roleName: string): boolean {
  const roles = getUserRoles();
  return roles.some(r => r.toLowerCase() === roleName.toLowerCase());
}

export function isAdmin(): boolean {
  const roles = getUserRoles();
  return roles.some(r => r === 'Admin' || r === 'admin' || r === 'Administrator');
}

export function isAuthenticated(): boolean {
  // Check if we have tokens
  if (!TokenManager.hasValidTokens()) {
    return false;
  }

  const token = TokenManager.getAccessToken();
  if (!token) {
    // If we have a refresh token but no access token, we can still refresh
    return TokenManager.getRefreshToken() !== null;
  }
  
  try {
    // Basic JWT token validation - check if it's not expired
    const payload = JSON.parse(atob(token.split('.')[1]));
    const currentTime = Math.floor(Date.now() / 1000);
    
    // If token has an expiration time and it's expired, check if we can refresh
    if (payload.exp && payload.exp < currentTime) {
      return TokenManager.getRefreshToken() !== null;
    }
    
    return true;
  } catch (error) {
    // If token is malformed, check if we can refresh
    return TokenManager.getRefreshToken() !== null;
  }
}

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

  const data = await response.json();
  localStorage.setItem("token", data.token); // store JWT
  return data.token;
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

  const data = await response.json();
  localStorage.setItem("token", data.token); // store JWT
  return data.token;
}

export function logout() {
  localStorage.removeItem("token");
}

export function getToken(): string | null {
  return localStorage.getItem("token");
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

// Deprecated: Use getUserRoles() instead - kept for backward compatibility
export function getUserRole(): string[] {
  return getUserRoles();
}

export function getAllRoles(): string[] {
  return getUserRoles();
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
  const token = getToken();
  if (!token) return false;
  
  try {
    // Basic JWT token validation - check if it's not expired
    const payload = JSON.parse(atob(token.split('.')[1]));
    const currentTime = Math.floor(Date.now() / 1000);
    
    // If token has an expiration time and it's expired, remove it
    if (payload.exp && payload.exp < currentTime) {
      logout();
      return false;
    }
    
    return true;
  } catch (error) {
    // If token is malformed, remove it
    logout();
    return false;
  }
}

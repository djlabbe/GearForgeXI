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

export function logout() {
  localStorage.removeItem("token");
}

export function getToken(): string | null {
  return localStorage.getItem("token");
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

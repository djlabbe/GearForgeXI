import { getToken } from "./authService";

export async function authFetch(input: RequestInfo, init: RequestInit = {}) {
  const token = getToken();

  const headers = {
    ...(init.headers || {}),
    ...(token ? { Authorization: `Bearer ${token}` } : {}),
  };

  return fetch(input, { ...init, headers });
}

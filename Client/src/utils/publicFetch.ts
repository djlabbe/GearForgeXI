/**
 * Utility for making API calls to public endpoints that don't require authentication
 */
export async function publicFetch(input: RequestInfo, init: RequestInit = {}): Promise<Response> {
  const headers = {
    'Content-Type': 'application/json',
    ...(init.headers || {}),
  };

  return fetch(input, { ...init, headers });
}

export default publicFetch;

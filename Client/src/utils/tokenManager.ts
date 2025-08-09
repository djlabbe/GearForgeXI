// Token management types
export interface TokenResponse {
  accessToken: string;
  refreshToken: string;
  expiresAt: string;
  message: string;
}

export interface RefreshTokenRequest {
  refreshToken: string;
}

// Token storage keys
const ACCESS_TOKEN_KEY = 'access_token';
const REFRESH_TOKEN_KEY = 'refresh_token';
const TOKEN_EXPIRY_KEY = 'token_expiry';

export class TokenManager {
  private static isRefreshing = false;

  // Save tokens to localStorage
  static saveTokens(tokenResponse: TokenResponse): void {
    localStorage.setItem(ACCESS_TOKEN_KEY, tokenResponse.accessToken);
    localStorage.setItem(REFRESH_TOKEN_KEY, tokenResponse.refreshToken);
    localStorage.setItem(TOKEN_EXPIRY_KEY, tokenResponse.expiresAt);
  }

  // Get current access token
  static getAccessToken(): string | null {
    return localStorage.getItem(ACCESS_TOKEN_KEY);
  }

  // Get refresh token
  static getRefreshToken(): string | null {
    return localStorage.getItem(REFRESH_TOKEN_KEY);
  }

  // Get token expiry
  static getTokenExpiry(): Date | null {
    const expiryString = localStorage.getItem(TOKEN_EXPIRY_KEY);
    return expiryString ? new Date(expiryString) : null;
  }

  // Check if token is expired or will expire soon (1 minute buffer)
  static isTokenExpired(): boolean {
    const expiry = this.getTokenExpiry();
    if (!expiry) return true;

    const now = new Date();
    const oneMinuteFromNow = new Date(now.getTime() + 1 * 60 * 1000);

    return expiry <= oneMinuteFromNow;
  }

  // Clear all tokens
  static clearTokens(): void {
    localStorage.removeItem(ACCESS_TOKEN_KEY);
    localStorage.removeItem(REFRESH_TOKEN_KEY);
    localStorage.removeItem(TOKEN_EXPIRY_KEY);
  }

  // Refresh access token using refresh token
  static async refreshAccessToken(): Promise<boolean> {
    // Prevent multiple simultaneous refresh attempts
    if (this.isRefreshing) {
      return false;
    }

    const refreshToken = this.getRefreshToken();
    if (!refreshToken) return false;

    this.isRefreshing = true;

    try {
      const response = await fetch('/api/account/refresh', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ refreshToken }),
      });

      if (response.ok) {
        const tokenResponse: TokenResponse = await response.json();
        this.saveTokens(tokenResponse);
        return true;
      } else {
        // Refresh token is invalid, clear all tokens
        this.clearTokens();
        return false;
      }
    } catch (error) {
      console.error('Error refreshing token:', error);
      return false;
    } finally {
      this.isRefreshing = false;
    }
  }

  // Get valid access token (refresh if needed)
  static async getValidAccessToken(): Promise<string | null> {
    if (this.isTokenExpired()) {
      const refreshed = await this.refreshAccessToken();
      if (!refreshed) return null;
    }
    return this.getAccessToken();
  }

  // Check if user has valid tokens
  static hasValidTokens(): boolean {
    const accessToken = this.getAccessToken();
    const refreshToken = this.getRefreshToken();
    return !!(accessToken && refreshToken);
  }

  // Revoke refresh token on server
  static async revokeRefreshToken(): Promise<void> {
    const refreshToken = this.getRefreshToken();
    
    if (refreshToken) {
      try {
        await fetch('/api/account/revoke', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({ refreshToken }),
        });
      } catch (error) {
        console.error('Error revoking token:', error);
      }
    }
  }
}

export default TokenManager;

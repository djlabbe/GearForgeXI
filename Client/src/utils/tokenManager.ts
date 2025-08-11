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
  private static refreshPromise: Promise<boolean> | null = null;

  // Save tokens to localStorage
  static saveTokens(tokenResponse: TokenResponse): void {
    localStorage.setItem(ACCESS_TOKEN_KEY, tokenResponse.accessToken);
    localStorage.setItem(REFRESH_TOKEN_KEY, tokenResponse.refreshToken);
    localStorage.setItem(TOKEN_EXPIRY_KEY, tokenResponse.expiresAt);
    
    console.log('TokenManager: Tokens saved', {
      expiresAt: tokenResponse.expiresAt,
      expiresIn: Math.round((new Date(tokenResponse.expiresAt).getTime() - Date.now()) / 1000 / 60) + ' minutes'
    });
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

  // Check if token is expired or will expire soon (5 minute buffer for better UX)
  static isTokenExpired(): boolean {
    const expiry = this.getTokenExpiry();
    if (!expiry) {
      console.log('TokenManager: No expiry found, considering expired');
      return true;
    }

    const now = new Date();
    const fiveMinutesFromNow = new Date(now.getTime() + 5 * 60 * 1000);
    const isExpired = expiry <= fiveMinutesFromNow;
    
    if (isExpired) {
      console.log('TokenManager: Token is expired or expiring soon', {
        expiry: expiry.toISOString(),
        now: now.toISOString(),
        minutesUntilExpiry: Math.round((expiry.getTime() - now.getTime()) / 1000 / 60)
      });
    }

    return isExpired;
  }

  // Clear all tokens
  static clearTokens(): void {
    localStorage.removeItem(ACCESS_TOKEN_KEY);
    localStorage.removeItem(REFRESH_TOKEN_KEY);
    localStorage.removeItem(TOKEN_EXPIRY_KEY);
  }

  // Refresh access token using refresh token
  static async refreshAccessToken(): Promise<boolean> {
    // If already refreshing, wait for the existing refresh to complete
    if (this.refreshPromise) {
      return await this.refreshPromise;
    }

    const refreshToken = this.getRefreshToken();
    if (!refreshToken) return false;

    // Create and store the refresh promise
    this.refreshPromise = this.performRefresh(refreshToken);
    
    try {
      const result = await this.refreshPromise;
      return result;
    } finally {
      this.refreshPromise = null;
    }
  }

  private static async performRefresh(refreshToken: string): Promise<boolean> {
    try {
      console.log('TokenManager: Starting token refresh...');
      
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
        console.log('TokenManager: Token refresh successful');
        return true;
      } else {
        console.log('TokenManager: Token refresh failed', {
          status: response.status,
          statusText: response.statusText
        });
        // Refresh token is invalid, clear all tokens
        this.clearTokens();
        return false;
      }
    } catch (error) {
      console.error('TokenManager: Error refreshing token:', error);
      this.clearTokens();
      return false;
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

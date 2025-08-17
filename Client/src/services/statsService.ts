import type { Stat } from "../models/Stat";
import { authFetch } from "../utils/authFetch";
import { publicFetch } from "../utils/publicFetch";

class StatsService {
  private static baseUrl = "/api";

  static async getStats(): Promise<Stat[]> {
    const response = await publicFetch(`${this.baseUrl}/stats`);
    if (!response.ok) {
      throw new Error(`Failed to fetch stats: ${response.statusText}`);
    }
    return response.json();
  }

  static async getBaseStats(): Promise<Stat[]> {
    const response = await publicFetch(`${this.baseUrl}/stats/base`);
    if (!response.ok) {
      throw new Error(`Failed to fetch base stats: ${response.statusText}`);
    }
    return response.json();
  }

  static async updateStat(stat: Stat): Promise<Stat> {
    const response = await authFetch(`${this.baseUrl}/stats/${stat.id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(stat),
    });

    if (!response.ok) {
      throw new Error(`Failed to update stat: ${response.statusText}`);
    }

    return response.json();
  }

  static async createStat(stat: Omit<Stat, "id">): Promise<Stat> {
    const response = await authFetch(`${this.baseUrl}/stats`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(stat),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create stat: ${errorText}`);
    }

    return response.json();
  }

  static async deleteStat(id: number): Promise<void> {
    const response = await authFetch(`${this.baseUrl}/stats/${id}`, {
      method: "DELETE",
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete stat: ${errorText}`);
    }
  }

  static async getAvailableStatCategories(): Promise<string[]> {
    const response = await publicFetch(`${this.baseUrl}/stats/categories`);
    if (!response.ok) {
      throw new Error(
        `Failed to fetch stat categories: ${response.statusText}`
      );
    }
    return response.json();
  }
}

export default StatsService;

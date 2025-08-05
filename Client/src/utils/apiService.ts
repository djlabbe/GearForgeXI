import type { Job } from '../models/Job';
import type { Stat } from '../models/Stat';

export interface GearItemSlotUpdateDto {
  slots: string[];
}

export interface GearItemCategoryUpdateDto {
  categoryName: string | null;
}

class ApiService {
  private static baseUrl = '/api';

  static async getStats(): Promise<Stat[]> {
    const response = await fetch(`${this.baseUrl}/stats`);
    if (!response.ok) {
      throw new Error(`Failed to fetch stats: ${response.statusText}`);
    }
    return response.json();
  }

  static async updateStat(stat: Stat): Promise<Stat> {
    const response = await fetch(`${this.baseUrl}/stats/${stat.id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(stat),
    });

    if (!response.ok) {
      throw new Error(`Failed to update stat: ${response.statusText}`);
    }

    return response.json();
  }

  static async createStat(stat: Omit<Stat, 'id'>): Promise<Stat> {
    const response = await fetch(`${this.baseUrl}/stats`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
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
    const response = await fetch(`${this.baseUrl}/stats/${id}`, {
      method: 'DELETE',
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete stat: ${errorText}`);
    }
  }

  static async getAvailableStatCategories(): Promise<string[]> {
    const response = await fetch(`${this.baseUrl}/stats/categories`);
    if (!response.ok) {
      throw new Error(`Failed to fetch stat categories: ${response.statusText}`);
    }
    return response.json();
  }

  static async getJobs(): Promise<Job[]> {
    const response = await fetch(`${this.baseUrl}/jobs`);
    if (!response.ok) {
      throw new Error(`Failed to fetch jobs: ${response.statusText}`);
    }
    return response.json();
  }

  static async getAvailableSlots(): Promise<string[]> {
    const response = await fetch(`${this.baseUrl}/gear/slots`);
    if (!response.ok) {
      throw new Error(`Failed to fetch available slots: ${response.statusText}`);
    }
    return response.json();
  }

  static async getAvailableGearCategories(): Promise<string[]> {
    const response = await fetch(`${this.baseUrl}/gear/categories`);
    if (!response.ok) {
      throw new Error(`Failed to fetch available categories: ${response.statusText}`);
    }
    return response.json();
  }

  static async updateGearItemSlots(itemId: number, slots: string[]): Promise<void> {
    const response = await fetch(`${this.baseUrl}/gear/${itemId}/slots`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({ slots } as GearItemSlotUpdateDto),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item slots: ${errorText}`);
    }
  }

  static async updateGearItemCategory(itemId: number, categoryName: string | null): Promise<void> {
    const response = await fetch(`${this.baseUrl}/gear/${itemId}/category`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({ categoryName } as GearItemCategoryUpdateDto),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item category: ${errorText}`);
    }
  }
}

export default ApiService;

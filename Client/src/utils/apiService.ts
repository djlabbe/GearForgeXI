import type { Job } from '../models/Job';
import type { Stat } from '../models/Stat';
import type { GearItem } from '../models/GearItem';
import { authFetch } from './authFetch';

export interface GearItemSlotUpdateDto {
  slots: string[];
}

export interface GearItemCategoryUpdateDto {
  categoryName: string | null;
}

export interface CreateGearItemDto {
  name: string;
  categoryName?: string;
  verified?: boolean;     // Admin verification flag
  stats: CreateGearStatDto[];
  jobs: string[];         // e.g., ["WAR", "NIN"]
  slots: string[];        // e.g., ["Main", "Sub"]
}

export interface CreateGearStatDto {
  statName: string;
  value: number;
}

class ApiService {
  private static baseUrl = '/api';

  static async getStats(): Promise<Stat[]> {
    const response = await authFetch(`${this.baseUrl}/stats`);
    if (!response.ok) {
      throw new Error(`Failed to fetch stats: ${response.statusText}`);
    }
    return response.json();
  }

  static async updateStat(stat: Stat): Promise<Stat> {
    const response = await authFetch(`${this.baseUrl}/stats/${stat.id}`, {
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
    const response = await authFetch(`${this.baseUrl}/stats`, {
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
    const response = await authFetch(`${this.baseUrl}/stats/${id}`, {
      method: 'DELETE',
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete stat: ${errorText}`);
    }
  }

  static async getAvailableStatCategories(): Promise<string[]> {
    const response = await authFetch(`${this.baseUrl}/stats/categories`);
    if (!response.ok) {
      throw new Error(`Failed to fetch stat categories: ${response.statusText}`);
    }
    return response.json();
  }

  static async getJobs(): Promise<Job[]> {
    const response = await authFetch(`${this.baseUrl}/jobs`);
    if (!response.ok) {
      throw new Error(`Failed to fetch jobs: ${response.statusText}`);
    }
    return response.json();
  }

  static async getAvailableSlots(): Promise<string[]> {
    const response = await authFetch(`${this.baseUrl}/gear/slots`);
    if (!response.ok) {
      throw new Error(`Failed to fetch available slots: ${response.statusText}`);
    }
    return response.json();
  }

  static async getAvailableGearCategories(): Promise<string[]> {
    const response = await authFetch(`${this.baseUrl}/gear/categories`);
    if (!response.ok) {
      throw new Error(`Failed to fetch available categories: ${response.statusText}`);
    }
    return response.json();
  }

  static async createGearItem(gearItemData: CreateGearItemDto): Promise<GearItem> {
    const response = await authFetch(`${this.baseUrl}/gear`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(gearItemData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create gear item: ${errorText}`);
    }

    return response.json();
  }

  static async updateGearItem(itemId: number, gearItemData: CreateGearItemDto): Promise<GearItem> {
    const response = await authFetch(`${this.baseUrl}/gear/${itemId}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(gearItemData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item: ${errorText}`);
    }

    return response.json();
  }

  static async updateGearItemSlots(itemId: number, slots: string[]): Promise<void> {
    const response = await authFetch(`${this.baseUrl}/gear/${itemId}/slots`, {
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
    const response = await authFetch(`${this.baseUrl}/gear/${itemId}/category`, {
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

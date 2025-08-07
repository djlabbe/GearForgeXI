import type { Job } from '../models/Job';
import type { Stat } from '../models/Stat';
import type { GearItem } from '../models/GearItem';
import type { GearSet } from '../models/GearSet';
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

export interface CreateGearSetDto {
  name: string;
  description?: string;
}

export interface CreateGearSetDto {
  name: string;
  description?: string;
  gearSetSlots: CreateGearSetSlotDto[];
}

export interface UpdateFullGearSetDto {
  name: string;
  description?: string;
  gearSetSlots: CreateGearSetSlotDto[];
}

export interface CreateGearSetSlotDto {
  gearItemId: number;
  position: string;
}

export interface AddGearSetSlotDto {
  gearItemId: number;
  gearSlotId: number;
  position: string;
}

export interface UpdateGearSetSlotDto {
  gearItemId: number;
  gearSlotId: number;
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

  static async getAvailableGearSlots(): Promise<string[]> {
    const response = await authFetch(`${this.baseUrl}/gear/slots`);
    if (!response.ok) {
      throw new Error(`Failed to fetch available slots: ${response.statusText}`);
    }
    return response.json();
  }

  static async getGearSlotMapping(): Promise<{ id: number; name: string }[]> {
    const response = await authFetch(`${this.baseUrl}/gear/slots/mapping`);
    if (!response.ok) {
      throw new Error(`Failed to fetch slot mapping: ${response.statusText}`);
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

  // GearSet methods
  static async getUserGearSets(): Promise<GearSet[]> {
    const response = await authFetch(`${this.baseUrl}/gearset`);
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch user gear sets: ${errorText}`);
    }
    return response.json();
  }


  static async createGearSet(gearSetData: CreateGearSetDto): Promise<GearSet> {
    const response = await authFetch(`${this.baseUrl}/gearset`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(gearSetData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create gear set: ${errorText}`);
    }

    return response.json();
  }

  static async updateFullGearSet(id: number, gearSetData: UpdateFullGearSetDto): Promise<GearSet> {
    const response = await authFetch(`${this.baseUrl}/gearset/${id}/full`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(gearSetData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update full gear set: ${errorText}`);
    }

    return response.json();
  }

  static async getGearSet(id: number): Promise<GearSet> {
    const response = await authFetch(`${this.baseUrl}/gearset/${id}`);
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch gear set: ${errorText}`);
    }
    return response.json();
  }

  static async addSlotToGearSet(gearSetId: number, slotData: AddGearSetSlotDto): Promise<void> {
    const response = await authFetch(`${this.baseUrl}/gearset/${gearSetId}/slots`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(slotData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to add slot to gear set: ${errorText}`);
    }
  }

  static async updateSlotInGearSet(gearSetId: number, position: string, slotData: UpdateGearSetSlotDto): Promise<void> {
    const response = await authFetch(`${this.baseUrl}/gearset/${gearSetId}/slots/${position}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(slotData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update slot in gear set: ${errorText}`);
    }
  }

  static async removeSlotFromGearSet(gearSetId: number, position: string): Promise<void> {
    const response = await authFetch(`${this.baseUrl}/gearset/${gearSetId}/slots/${position}`, {
      method: 'DELETE',
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to remove slot from gear set: ${errorText}`);
    }
  }
}

export default ApiService;

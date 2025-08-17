import type { GearItem } from "../models/GearItem";
import { authFetch } from "../utils/authFetch";
import { publicFetch } from "../utils/publicFetch";

export interface GearItemSlotUpdateDto {
  slots: string[];
}

export interface GearItemCategoryUpdateDto {
  categoryName: string | null;
}

export interface CreateGearItemDto {
  name: string;
  categoryName?: string;
  rank?: number;
  path?: string;
  verified?: boolean; // Admin verification flag
  stats: CreateGearStatDto[];
  jobs: string[]; // e.g., ["WAR", "NIN"]
  slots: string[]; // e.g., ["Main", "Sub"]
}

export interface CreateGearStatDto {
  statName: string;
  value: number | null;
}

class GearService {
  private static baseUrl = "/api";

  static async getAvailableGearSlots(): Promise<string[]> {
    const response = await publicFetch(`${this.baseUrl}/gear/slots`);
    if (!response.ok) {
      throw new Error(
        `Failed to fetch available slots: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async getGearSlotMapping(): Promise<{ id: number; name: string }[]> {
    const response = await publicFetch(`${this.baseUrl}/gear/slots/mapping`);
    if (!response.ok) {
      throw new Error(`Failed to fetch slot mapping: ${response.statusText}`);
    }
    return response.json();
  }

  static async getAvailableGearCategories(): Promise<string[]> {
    const response = await publicFetch(`${this.baseUrl}/gear/categories`);
    if (!response.ok) {
      throw new Error(
        `Failed to fetch available categories: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async createGearItem(
    gearItemData: CreateGearItemDto
  ): Promise<GearItem> {
    const response = await authFetch(`${this.baseUrl}/gear`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(gearItemData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create gear item: ${errorText}`);
    }

    return response.json();
  }

  static async updateGearItem(
    itemId: number,
    gearItemData: CreateGearItemDto
  ): Promise<GearItem> {
    const response = await authFetch(`${this.baseUrl}/gear/${itemId}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(gearItemData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item: ${errorText}`);
    }

    return response.json();
  }

  static async updateGearItemSlots(
    itemId: number,
    slots: string[]
  ): Promise<void> {
    const response = await authFetch(`${this.baseUrl}/gear/${itemId}/slots`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ slots } as GearItemSlotUpdateDto),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item slots: ${errorText}`);
    }
  }

  static async updateGearItemCategory(
    itemId: number,
    categoryName: string | null
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/gear/${itemId}/category`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ categoryName } as GearItemCategoryUpdateDto),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear item category: ${errorText}`);
    }
  }

  static async getGearItemsByStat(statId: number): Promise<GearItem[]> {
    const response = await authFetch(`${this.baseUrl}/gear?statId=${statId}`);
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch gear items by stat: ${errorText}`);
    }
    return response.json();
  }
}

export default GearService;

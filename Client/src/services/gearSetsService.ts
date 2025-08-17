import type { GearSet } from "../models/GearSet";
import { authFetch } from "../utils/authFetch";

export interface CreateGearSetDto {
  name: string;
  description?: string;
  jobId: number;
  gearSetSlots: CreateGearSetSlotDto[];
}

export interface UpdateGearSetDto {
  name: string;
  description?: string;
  jobId: number;
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

class GearSetsService {
  private static baseUrl = "/api";

  static async getUserGearSets(): Promise<GearSet[]> {
    const response = await authFetch(`${this.baseUrl}/gearsets`);
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch user gear sets: ${errorText}`);
    }
    return response.json();
  }

  static async createGearSet(gearSetData: CreateGearSetDto): Promise<GearSet> {
    const response = await authFetch(`${this.baseUrl}/gearsets`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(gearSetData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create gear set: ${errorText}`);
    }

    return response.json();
  }

  static async updateGearSet(
    id: number,
    gearSetData: UpdateGearSetDto
  ): Promise<GearSet> {
    const response = await authFetch(`${this.baseUrl}/gearsets/${id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(gearSetData),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update gear set: ${errorText}`);
    }

    return response.json();
  }

  static async getGearSet(id: number): Promise<GearSet> {
    const response = await authFetch(`${this.baseUrl}/gearsets/${id}`);
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch gear set: ${errorText}`);
    }
    return response.json();
  }

  static async addSlotToGearSet(
    gearSetId: number,
    slotData: AddGearSetSlotDto
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/gearsets/${gearSetId}/slots`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(slotData),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to add slot to gear set: ${errorText}`);
    }
  }

  static async updateSlotInGearSet(
    gearSetId: number,
    position: string,
    slotData: UpdateGearSetSlotDto
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/gearsets/${gearSetId}/slots/${position}`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(slotData),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update slot in gear set: ${errorText}`);
    }
  }

  static async removeSlotFromGearSet(
    gearSetId: number,
    position: string
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/gearsets/${gearSetId}/slots/${position}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to remove slot from gear set: ${errorText}`);
    }
  }
}

export default GearSetsService;

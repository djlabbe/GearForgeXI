import type {
  CharacterProfile,
  CreateCharacterProfileDto,
  UpdateCharacterProfileDto,
  UpdateCharacterJobDto,
} from "../models/CharacterProfile";
import { authFetch } from "../utils/authFetch";

class CharacterProfileService {
  static async getCharacterProfiles(): Promise<CharacterProfile[]> {
    const response = await authFetch("/api/characterprofile");
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch character profiles: ${errorText}`);
    }
    return response.json();
  }

  static async getCharacterProfile(id: number): Promise<CharacterProfile> {
    const response = await authFetch(`/api/characterprofile/${id}`);
    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to fetch character profile: ${errorText}`);
    }
    return response.json();
  }

  static async createCharacterProfile(
    profile: CreateCharacterProfileDto
  ): Promise<{ id: number }> {
    const response = await authFetch("/api/characterprofile", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(profile),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create character profile: ${errorText}`);
    }
    return response.json();
  }

  static async updateCharacterProfile(
    id: number,
    profile: UpdateCharacterProfileDto
  ): Promise<void> {
    const response = await authFetch(`/api/characterprofile/${id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(profile),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update character profile: ${errorText}`);
    }
  }

  static async deleteCharacterProfile(id: number): Promise<void> {
    const response = await authFetch(`/api/characterprofile/${id}`, {
      method: "DELETE",
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete character profile: ${errorText}`);
    }
  }

  static async updateCharacterJobs(
    profileId: number,
    characterJobs: UpdateCharacterJobDto[]
  ): Promise<void> {
    const response = await authFetch(
      `/api/characterprofile/${profileId}/character-jobs`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(characterJobs),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update character jobs: ${errorText}`);
    }
  }
}

export default CharacterProfileService;

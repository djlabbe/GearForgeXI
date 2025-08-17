import type {
  RaceConfiguration,
  CreateRaceConfigurationDto,
  UpdateRaceConfigurationDto,
  CreateRaceBaseStatDto,
} from "../models/RaceConfiguration";
import { authFetch } from "../utils/authFetch";

class RaceConfigurationService {
  private static baseUrl = "/api";

  static async getRaceConfigurations(): Promise<RaceConfiguration[]> {
    const response = await authFetch(`${this.baseUrl}/raceconfigurations`);
    if (!response.ok) {
      throw new Error(
        `Failed to fetch race configurations: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async getRaceConfiguration(id: number): Promise<RaceConfiguration> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/${id}`
    );
    if (!response.ok) {
      throw new Error(
        `Failed to fetch race configuration: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async getRaceConfigurationByAbbreviation(
    abbreviation: string
  ): Promise<RaceConfiguration> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/by-abbreviation/${abbreviation}`
    );
    if (!response.ok) {
      throw new Error(
        `Failed to fetch race configuration: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async createRaceConfiguration(
    raceConfiguration: CreateRaceConfigurationDto
  ): Promise<RaceConfiguration> {
    const response = await authFetch(`${this.baseUrl}/raceconfigurations`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(raceConfiguration),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create race configuration: ${errorText}`);
    }

    return response.json();
  }

  static async updateRaceConfiguration(
    raceConfiguration: UpdateRaceConfigurationDto
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/${raceConfiguration.id}`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(raceConfiguration),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update race configuration: ${errorText}`);
    }
  }

  static async deleteRaceConfiguration(id: number): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/${id}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      throw new Error(
        `Failed to delete race configuration: ${response.statusText}`
      );
    }
  }

  static async addRaceBaseStat(
    raceId: number,
    baseStat: CreateRaceBaseStatDto
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/${raceId}/base-stats`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(baseStat),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to add race base stat: ${errorText}`);
    }
  }

  static async updateRaceBaseStat(
    raceId: number,
    statId: number,
    value: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/${raceId}/base-stats/${statId}`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(value),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update race base stat: ${errorText}`);
    }
  }

  static async deleteRaceBaseStat(
    raceId: number,
    statId: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/raceconfigurations/${raceId}/base-stats/${statId}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      throw new Error(
        `Failed to delete race base stat: ${response.statusText}`
      );
    }
  }
}

export default RaceConfigurationService;

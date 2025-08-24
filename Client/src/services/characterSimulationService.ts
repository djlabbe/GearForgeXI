import { authFetch } from "../utils/authFetch";
import type { 
  CalculateStatsRequest, 
  CharacterSimulationResponse, 
  SimulationError 
} from "../models/CharacterSimulation";

class CharacterSimulationService {
  private static baseUrl = "/api/charactersimulation";

  /**
   * Calculate character stats for a given configuration
   */
  static async calculateCharacterStats(request: CalculateStatsRequest): Promise<CharacterSimulationResponse> {
    try {
      const response = await authFetch(`${this.baseUrl}/calculate`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(request),
      });

      if (!response.ok) {
        const errorData: SimulationError = await response.json();
        throw new Error(errorData.message || `HTTP error! status: ${response.status}`);
      }

      const result: CharacterSimulationResponse = await response.json();
      return result;
    } catch (error) {
      if (error instanceof Error) {
        throw error;
      }
      throw new Error("An unexpected error occurred during simulation");
    }
  }

  /**
   * Get available job configurations
   */
  static async getJobConfigurations(): Promise<any[]> {
    try {
      const response = await authFetch(`${this.baseUrl}/job-configurations`);

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      if (error instanceof Error) {
        throw error;
      }
      throw new Error("Failed to fetch job configurations");
    }
  }
}

export default CharacterSimulationService;

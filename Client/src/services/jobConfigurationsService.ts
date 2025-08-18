import type { JobConfiguration, JobBaseStat, JobTrait } from "../models/JobConfiguration";
import { authFetch } from "../utils/authFetch";

interface CreateJobBaseStatDto {
  statId: number;
  value: number;
}

interface CreateJobTraitDto {
  name: string;
  level?: number;
  statId: number;
  value: number;
}

class JobConfigurationsService {
  private static baseUrl = "/api";

  static async getJobConfigurations(): Promise<JobConfiguration[]> {
    const response = await authFetch(`${this.baseUrl}/jobconfigurations`);
    if (!response.ok) {
      throw new Error(
        `Failed to fetch job configurations: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async getJobConfiguration(id: number): Promise<JobConfiguration> {
    const response = await authFetch(`${this.baseUrl}/jobconfigurations/${id}`);
    if (!response.ok) {
      throw new Error(
        `Failed to fetch job configuration: ${response.statusText}`
      );
    }
    return response.json();
  }

  static async addJobBaseStat(
    jobConfigurationId: number,
    createDto: CreateJobBaseStatDto
  ): Promise<JobBaseStat> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/base-stats`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(createDto),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to add job base stat: ${errorText}`);
    }

    return response.json();
  }

  static async updateJobBaseStat(
    jobConfigurationId: number,
    statId: number,
    value: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/base-stats/${statId}`,
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
      throw new Error(`Failed to update job base stat: ${errorText}`);
    }
  }

  static async deleteJobBaseStat(
    jobConfigurationId: number,
    statId: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/base-stats/${statId}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete job base stat: ${errorText}`);
    }
  }

  // Job Traits Management
  static async addJobTrait(
    jobConfigurationId: number,
    createDto: CreateJobTraitDto
  ): Promise<JobTrait> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/traits`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(createDto),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to add job trait: ${errorText}`);
    }

    return response.json();
  }

  static async updateJobTrait(
    jobConfigurationId: number,
    traitId: number,
    updateDto: CreateJobTraitDto
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/traits/${traitId}`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(updateDto),
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update job trait: ${errorText}`);
    }
  }

  static async deleteJobTrait(
    jobConfigurationId: number,
    traitId: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/traits/${traitId}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete job trait: ${errorText}`);
    }
  }
}

export default JobConfigurationsService;

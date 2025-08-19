import type {
  JobConfiguration,
  JobBaseStat,
  JobTrait,
  JobPointBonus,
  JobGift,
  MasterLevelBonus,
} from "../models/JobConfiguration";
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

interface CreateJobPointBonusDto {
  statId: number;
  value: number;
}

interface CreateJobGiftDto {
  statId: number;
  value: number;
}

interface CreateMasterLevelBonusDto {
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

  // Job Point Bonuses Management
  static async addJobPointBonus(
    jobConfigurationId: number,
    createDto: CreateJobPointBonusDto
  ): Promise<JobPointBonus> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/job-point-bonuses`,
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
      throw new Error(`Failed to add job point bonus: ${errorText}`);
    }

    return response.json();
  }

  static async updateJobPointBonus(
    jobConfigurationId: number,
    statId: number,
    value: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/job-point-bonuses/${statId}`,
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
      throw new Error(`Failed to update job point bonus: ${errorText}`);
    }
  }

  static async deleteJobPointBonus(
    jobConfigurationId: number,
    statId: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/job-point-bonuses/${statId}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete job point bonus: ${errorText}`);
    }
  }

  // Job Gifts Management
  static async addJobGift(
    jobConfigurationId: number,
    createDto: CreateJobGiftDto
  ): Promise<JobGift> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/job-gifts`,
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
      throw new Error(`Failed to add job gift: ${errorText}`);
    }

    return response.json();
  }

  static async updateJobGift(
    jobConfigurationId: number,
    statId: number,
    value: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/job-gifts/${statId}`,
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
      throw new Error(`Failed to update job gift: ${errorText}`);
    }
  }

  static async deleteJobGift(
    jobConfigurationId: number,
    statId: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/job-gifts/${statId}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete job gift: ${errorText}`);
    }
  }

  // Master Level Bonuses Management
  static async addMasterLevelBonus(
    jobConfigurationId: number,
    createDto: CreateMasterLevelBonusDto
  ): Promise<MasterLevelBonus> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/master-level-bonuses`,
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
      throw new Error(`Failed to add master level bonus: ${errorText}`);
    }

    return response.json();
  }

  static async updateMasterLevelBonus(
    jobConfigurationId: number,
    statId: number,
    value: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/master-level-bonuses/${statId}`,
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
      throw new Error(`Failed to update master level bonus: ${errorText}`);
    }
  }

  static async deleteMasterLevelBonus(
    jobConfigurationId: number,
    statId: number
  ): Promise<void> {
    const response = await authFetch(
      `${this.baseUrl}/jobconfigurations/${jobConfigurationId}/master-level-bonuses/${statId}`,
      {
        method: "DELETE",
      }
    );

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete master level bonus: ${errorText}`);
    }
  }
}

export default JobConfigurationsService;

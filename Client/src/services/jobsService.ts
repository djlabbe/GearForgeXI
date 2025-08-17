import type { Job } from "../models/Job";
import { authFetch } from "../utils/authFetch";
import { publicFetch } from "../utils/publicFetch";

class JobsService {
  private static baseUrl = "/api";

  static async getJobs(): Promise<Job[]> {
    const response = await publicFetch(`${this.baseUrl}/jobs`);
    if (!response.ok) {
      throw new Error(`Failed to fetch jobs: ${response.statusText}`);
    }
    return response.json();
  }

  static async getJob(id: number): Promise<Job> {
    const response = await publicFetch(`${this.baseUrl}/jobs/${id}`);
    if (!response.ok) {
      throw new Error(`Failed to fetch job: ${response.statusText}`);
    }
    return response.json();
  }

  static async createJob(job: Omit<Job, "id">): Promise<Job> {
    const response = await authFetch(`/api/jobs`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(job),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to create job: ${errorText}`);
    }

    return response.json();
  }

  static async updateJob(job: Job): Promise<Job> {
    const response = await authFetch(`/api/jobs/${job.id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        abbreviation: job.abbreviation,
        fullName: job.fullName,
        canDualWield: job.canDualWield,
      }),
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to update job: ${errorText}`);
    }

    return job; // Return the updated job since PUT returns 204 No Content
  }

  static async deleteJob(id: number): Promise<void> {
    const response = await authFetch(`/api/jobs/${id}`, {
      method: "DELETE",
    });

    if (!response.ok) {
      const errorText = await response.text();
      throw new Error(`Failed to delete job: ${errorText}`);
    }
  }

  static async checkJobAbbreviationAvailable(
    abbreviation: string,
    excludeId?: number
  ): Promise<boolean> {
    const url = excludeId
      ? `${this.baseUrl}/jobs/check-abbreviation/${encodeURIComponent(
          abbreviation
        )}?excludeId=${excludeId}`
      : `${this.baseUrl}/jobs/check-abbreviation/${encodeURIComponent(
          abbreviation
        )}`;

    const response = await publicFetch(url);
    if (!response.ok) {
      throw new Error(
        `Failed to check abbreviation availability: ${response.statusText}`
      );
    }
    return response.json();
  }
}

export default JobsService;

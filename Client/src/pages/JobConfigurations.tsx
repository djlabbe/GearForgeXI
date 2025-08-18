import { useState, useEffect } from "react";
import { JobConfigurationsService } from "../services";
import { useAuth } from "../contexts/AuthContext";
import JobBaseStatsGrid from "../components/JobBaseStatsGrid";
import JobTraitsGrid from "../components/JobTraitsGrid";
import JobPointBonusesGrid from "../components/JobPointBonusesGrid";
import MasterLevelBonusesGrid from "../components/MasterLevelBonusesGrid";

import type {
  JobConfiguration,
  JobBaseStat,
  JobTrait,
  JobPointBonus,
  MasterLevelBonus,
} from "../models/JobConfiguration";

export function JobConfigurations() {
  const { isAdmin } = useAuth();
  const [jobConfigurations, setJobConfigurations] = useState<
    JobConfiguration[]
  >([]);
  const [selectedJobConfig, setSelectedJobConfig] =
    useState<JobConfiguration | null>(null);

  // Separate state for each grid to prevent unnecessary re-renders
  const [jobBaseStats, setJobBaseStats] = useState<JobBaseStat[]>([]);
  const [jobTraits, setJobTraits] = useState<JobTrait[]>([]);
  const [jobPointBonuses, setJobPointBonuses] = useState<JobPointBonus[]>([]);
  const [masterLevelBonuses, setMasterLevelBonus] = useState<
    MasterLevelBonus[]
  >([]);

  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const isDarkMode = window.matchMedia("(prefers-color-scheme: dark)").matches;

  // Load job configurations
  useEffect(() => {
    const loadJobConfigurations = async () => {
      try {
        setLoading(true);
        setError(null);
        const data = await JobConfigurationsService.getJobConfigurations();
        setJobConfigurations(data);
        // Auto-select the first configuration if available
        if (data.length > 0) {
          const firstConfig = data[0];
          setSelectedJobConfig(firstConfig);
          // Initialize separate grid state
          setJobBaseStats(firstConfig.jobBaseStats || []);
          setJobTraits(firstConfig.jobTraits || []);
          setJobPointBonuses(firstConfig.jobPointBonuses || []);
          setMasterLevelBonus(firstConfig.masterLevelBonuses || []);
        }
      } catch (err) {
        setError(
          err instanceof Error
            ? err.message
            : "Failed to load job configurations"
        );
        console.error("Error loading job configurations:", err);
      } finally {
        setLoading(false);
      }
    };

    loadJobConfigurations();
  }, []);

  const handleJobConfigChange = (
    event: React.ChangeEvent<HTMLSelectElement>
  ) => {
    const configId = parseInt(event.target.value);
    const config = jobConfigurations.find((jc) => jc.id === configId);
    setSelectedJobConfig(config || null);

    // Update separate grid state when job configuration changes
    if (config) {
      setJobBaseStats(config.jobBaseStats || []);
      setJobTraits(config.jobTraits || []);
      setJobPointBonuses(config.jobPointBonuses || []);
      setMasterLevelBonus(config.masterLevelBonuses || []);
    } else {
      setJobBaseStats([]);
      setJobTraits([]);
      setJobPointBonuses([]);
      setMasterLevelBonus([]);
    }
  };


  if (loading) {
    return (
      <div className="flex items-center justify-center h-64">
        <div className="text-center">
          <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mx-auto"></div>
          <p className="mt-2 text-sm text-gray-600 dark:text-gray-400">
            Loading job configurations...
          </p>
        </div>
      </div>
    );
  }

  if (!isAdmin) {
    return (
      <div className="text-center py-8">
        <h2 className="text-xl font-semibold text-gray-900 dark:text-white">
          Access Denied
        </h2>
        <p className="mt-2 text-gray-600 dark:text-gray-400">
          You need administrator privileges to view job configurations.
        </p>
      </div>
    );
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div className="flex justify-between items-center">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          Job Configurations
        </h1>
      </div>

      {/* Error Message */}
      {error && (
        <div className="bg-red-50 dark:bg-red-900/20 border border-red-200 dark:border-red-800 text-red-700 dark:text-red-200 px-4 py-3 rounded-lg">
          {error}
        </div>
      )}

      {/* Job Configuration Selector */}
      <div className="bg-white dark:bg-gray-800 p-4 rounded-lg border border-gray-200 dark:border-gray-700">
        <label
          htmlFor="job-config-select"
          className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
        >
          Select Job Configuration
        </label>
        <select
          id="job-config-select"
          value={selectedJobConfig?.id || ""}
          onChange={handleJobConfigChange}
          className="w-full max-w-md p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-blue-500 focus:border-blue-500"
        >
          <option value="">Select a job configuration...</option>
          {jobConfigurations.map((config) => (
            <option key={config.id} value={config.id}>
              {config.job.fullName} ({config.job.abbreviation})
            </option>
          ))}
        </select>
      </div>

      {/* Selected Job Configuration Details */}
      {selectedJobConfig && (
        <div className="space-y-6">

          {/* First Row - Base Stats and Traits (Side by side on lg+ screens) */}
          <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
            <JobBaseStatsGrid
              jobBaseStats={jobBaseStats}
              onJobBaseStatsChange={setJobBaseStats}
              jobConfigurationId={selectedJobConfig.id}
              isAdmin={isAdmin}
              isDarkMode={isDarkMode}
            />

            <JobTraitsGrid
              jobTraits={jobTraits}
              onJobTraitsChange={setJobTraits}
              jobConfigurationId={selectedJobConfig.id}
              isAdmin={isAdmin}
              isDarkMode={isDarkMode}
            />
          </div>

          <JobPointBonusesGrid
            jobPointBonuses={jobPointBonuses}
            onJobPointBonusesChange={setJobPointBonuses}
            jobConfigurationId={selectedJobConfig.id}
            isAdmin={isAdmin}
            isDarkMode={isDarkMode}
          />

          <MasterLevelBonusesGrid
            masterLevelBonuses={masterLevelBonuses}
            onMasterLevelBonusesChange={setMasterLevelBonus}
            jobConfigurationId={selectedJobConfig.id}
            isAdmin={isAdmin}
            isDarkMode={isDarkMode}
          />
        </div>
      )}

      {/* No Selection Message */}
      {!selectedJobConfig && jobConfigurations.length > 0 && (
        <div className="text-center py-8">
          <h2 className="text-xl font-semibold text-gray-900 dark:text-white">
            Select a Job Configuration
          </h2>
          <p className="mt-2 text-gray-600 dark:text-gray-400">
            Choose a job configuration from the dropdown above to view and
            manage its details.
          </p>
        </div>
      )}

      {/* No Configurations Available */}
      {jobConfigurations.length === 0 && !loading && (
        <div className="text-center py-8">
          <h2 className="text-xl font-semibold text-gray-900 dark:text-white">
            No Job Configurations Found
          </h2>
          <p className="mt-2 text-gray-600 dark:text-gray-400">
            Create your first job configuration to get started.
          </p>
        </div>
      )}
    </div>
  );
}

export default JobConfigurations;

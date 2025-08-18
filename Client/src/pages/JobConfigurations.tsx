import { useState, useEffect } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import { useAuth } from "../contexts/AuthContext";
import JobBaseStatsGrid from "../components/JobBaseStatsGrid";

import type { ColDef } from "ag-grid-community";
import type {
  JobConfiguration,
  JobBaseStat,
  JobTrait,
  JobPointBonus,
  MasterLevelBonus,
} from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

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

  // Column definitions for Job Traits
  const traitsColumnDefs: ColDef<JobTrait>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Name",
      field: "name",
      width: 200,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Level",
      field: "level",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 150,
      editable: false,
      valueGetter: (params) =>
        params.data?.stat?.displayName || params.data?.stat?.name,
    },
    {
      headerName: "Value",
      field: "value",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
  ];

  // Column definitions for Job Point Bonuses
  const jpBonusesColumnDefs: ColDef<JobPointBonus>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Category",
      field: "category",
      width: 200,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 150,
      editable: false,
      valueGetter: (params) =>
        params.data?.stat?.displayName || params.data?.stat?.name,
    },
    {
      headerName: "Value",
      field: "value",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
  ];

  // Column definitions for Master Level Bonuses
  const mlBonusesColumnDefs: ColDef<MasterLevelBonus>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Level",
      field: "level",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 150,
      editable: false,
      valueGetter: (params) =>
        params.data?.stat?.displayName || params.data?.stat?.name,
    },
    {
      headerName: "Value",
      field: "value",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
  ];

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

  const handleJobBaseStatSync = (newJobBaseStat: JobBaseStat) => {
    // Update the main configurations list and selected config
    if (selectedJobConfig) {
      const updatedConfig = {
        ...selectedJobConfig,
        jobBaseStats: [...jobBaseStats, newJobBaseStat],
      };
      setSelectedJobConfig(updatedConfig);

      setJobConfigurations((prev) =>
        prev.map((config) =>
          config.id === selectedJobConfig.id ? updatedConfig : config
        )
      );
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
          {/* Job Info Summary */}
          <div className="bg-white dark:bg-gray-800 p-4 rounded-lg border border-gray-200 dark:border-gray-700">
            <h2 className="text-lg font-semibold text-gray-900 dark:text-white mb-2">
              Job
            </h2>
            <div className="grid grid-cols-2 md:grid-cols-4 gap-4 text-sm">
              <div>
                <span className="text-gray-600 dark:text-gray-400">
                  Abbreviation:
                </span>
                <span className="ml-2 font-medium">
                  {selectedJobConfig.job.abbreviation}
                </span>
              </div>
              <div>
                <span className="text-gray-600 dark:text-gray-400">
                  Dual Wield:
                </span>
                <span
                  className={`ml-2 inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-medium ${
                    selectedJobConfig.job.canDualWield
                      ? "bg-green-100 text-green-800 dark:bg-green-900/20 dark:text-green-400"
                      : "bg-gray-100 text-gray-800 dark:bg-gray-900/20 dark:text-gray-400"
                  }`}
                >
                  {selectedJobConfig.job.canDualWield ? "Yes" : "No"}
                </span>
              </div>
              <div>
                <span className="text-gray-600 dark:text-gray-400">
                  Base Stats:
                </span>
                <span className="ml-2 font-medium">{jobBaseStats.length}</span>
              </div>
              <div>
                <span className="text-gray-600 dark:text-gray-400">
                  Traits:
                </span>
                <span className="ml-2 font-medium">{jobTraits.length}</span>
              </div>
            </div>
          </div>

          {/* Job Base Stats Grid */}
          <JobBaseStatsGrid
            jobBaseStats={jobBaseStats}
            onJobBaseStatsChange={setJobBaseStats}
            jobConfigurationId={selectedJobConfig.id}
            isAdmin={isAdmin}
            isDarkMode={isDarkMode}
          />

          {/* Job Traits Grid */}
          <div className="space-y-2">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
              Job Traits ({jobTraits.length})
            </h3>
            <div
              className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
              style={{ height: 300, width: "100%" }}
            >
              <AgGridReact<JobTrait>
                theme={isDarkMode ? themeDarkBlue : themeAlpine}
                rowData={jobTraits}
                columnDefs={traitsColumnDefs}
                defaultColDef={{
                  resizable: true,
                  sortable: true,
                  filter: true,
                }}
              />
            </div>
          </div>

          {/* Job Point Bonuses Grid */}
          <div className="space-y-2">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
              Job Point Bonuses ({jobPointBonuses.length})
            </h3>
            <div
              className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
              style={{ height: 300, width: "100%" }}
            >
              <AgGridReact<JobPointBonus>
                theme={isDarkMode ? themeDarkBlue : themeAlpine}
                rowData={jobPointBonuses}
                columnDefs={jpBonusesColumnDefs}
                defaultColDef={{
                  resizable: true,
                  sortable: true,
                  filter: true,
                }}
              />
            </div>
          </div>

          {/* Master Level Bonuses Grid */}
          <div className="space-y-2">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
              Master Level Bonuses ({masterLevelBonuses.length})
            </h3>
            <div
              className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
              style={{ height: 300, width: "100%" }}
            >
              <AgGridReact<MasterLevelBonus>
                theme={isDarkMode ? themeDarkBlue : themeAlpine}
                rowData={masterLevelBonuses}
                columnDefs={mlBonusesColumnDefs}
                defaultColDef={{
                  resizable: true,
                  sortable: true,
                  filter: true,
                }}
              />
            </div>
          </div>
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

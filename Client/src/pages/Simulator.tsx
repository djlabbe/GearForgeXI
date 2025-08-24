import { useState, useEffect } from "react";
import { useAppData } from "../contexts/AppDataContext";
import { useGearSetState } from "../hooks/useGearSetState";
import { ReactSelector } from "../components/ReactSelector";
import Card from "../components/Card";
import type { Job } from "../models/Job";
import type { GearSet } from "../models/GearSet";

export function Simulator() {
  const { jobs, loading: loadingAppData, error } = useAppData();
  const [selectedJob, setSelectedJob] = useState<Job | undefined>();
  const [masterLevel, setMasterLevel] = useState<number | undefined>(undefined);
  const [selectedSubJob, setSelectedSubJob] = useState<Job | undefined>();
  const [selectedGearSet, setSelectedGearSet] = useState<GearSet | undefined>();
  
  // Calculate sub job level based on master level: 49 + (masterLevel / 5)
  const subJobLevel = masterLevel !== undefined ? Math.floor(49 + (masterLevel / 5)) : 1;

  // Get gear sets for the selected job
  const { savedGearSets } = useGearSetState(selectedJob!, true);

  // Check if required fields are filled for submit button
  const canSubmit = selectedJob && masterLevel !== undefined && selectedGearSet;

  // Clear sub job if it matches the main job
  useEffect(() => {
    if (
      selectedJob &&
      selectedSubJob &&
      selectedJob.abbreviation === selectedSubJob.abbreviation
    ) {
      setSelectedSubJob(undefined);
    }
  }, [selectedJob, selectedSubJob]);

  const jobOptions =
    jobs?.map((job) => ({
      value: job.abbreviation,
      label: `${job.fullName} (${job.abbreviation})`,
    })) || [];

  // Filter options to prevent selecting the same job for both main and sub
  const availableSubJobOptions = jobOptions.filter(
    (option) => option.value !== selectedJob?.abbreviation
  );

  // Clear sub job if it's no longer available in the filtered options
  useEffect(() => {
    if (
      selectedSubJob &&
      !availableSubJobOptions.find(
        (opt) => opt.value === selectedSubJob.abbreviation
      )
    ) {
      setSelectedSubJob(undefined);
    }
  }, [availableSubJobOptions, selectedSubJob]);

  const handleJobChange = (option: any) => {
    setSelectedJob(jobs?.find((job) => job.abbreviation === option?.value));
    // Clear selected gear set when job changes
    setSelectedGearSet(undefined);
  };

  const handleSubJobChange = (option: any) => {
    setSelectedSubJob(jobs?.find((job) => job.abbreviation === option?.value));
  };

  const handleSubmit = () => {
    if (canSubmit) {
      // TODO: Implement simulation logic
      console.log('Starting simulation with:', {
        job: selectedJob,
        masterLevel,
        subJob: selectedSubJob,
        subJobLevel,
        gearSet: selectedGearSet
      });
    }
  };

  return (
    <>
      <div className="flex justify-between items-center mb-4">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          Character Simulator
        </h1>
      </div>
      
      <Card className="mb-4">
        {loadingAppData ? (
          <div className="text-gray-500">Loading...</div>
        ) : error ? (
          <div className="text-red-500">Error: {error}</div>
        ) : (
          <div className="space-y-6">
            {/* Job Configuration */}
            <div className="flex flex-col gap-6 lg:flex-row lg:gap-8 lg:items-start">
              {/* Main Job Column */}
              <div className="flex-1 space-y-4">
                <div>
                  <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                    Main Job *
                  </label>
                  <ReactSelector
                    value={jobOptions.find(
                      (opt) => opt.value === selectedJob?.abbreviation
                    )}
                    onChange={handleJobChange}
                    options={jobOptions}
                    placeholder="Select main job..."
                  />
                </div>
                <div>
                  <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                    Master Level *
                  </label>
                  <input
                    type="number"
                    min="0"
                    max="50"
                    value={masterLevel ?? ''}
                    onChange={(e) => setMasterLevel(e.target.value ? parseInt(e.target.value) : undefined)}
                    className="w-full px-3 py-2 border border-gray-300 rounded-md bg-white text-gray-900 focus:outline-none focus:ring-2 focus:ring-blue-600 focus:border-blue-600 dark:bg-gray-700 dark:border-gray-600 dark:text-gray-100 dark:focus:ring-blue-600 dark:focus:border-blue-600"
                    placeholder="0-50"
                  />
                </div>
              </div>

              {/* Separator */}
              <div className="flex items-center justify-center lg:pt-12">
                <span className="text-6xl font-light text-gray-400 dark:text-gray-500 select-none">
                  /
                </span>
              </div>

              {/* Sub Job Column */}
              <div className="flex-1 space-y-4">
                <div>
                  <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                    Sub Job
                  </label>
                  <ReactSelector
                    value={
                      selectedSubJob &&
                      availableSubJobOptions.find(
                        (opt) => opt.value === selectedSubJob.abbreviation
                      )
                        ? availableSubJobOptions.find(
                            (opt) => opt.value === selectedSubJob.abbreviation
                          )
                        : null
                    }
                    onChange={handleSubJobChange}
                    options={availableSubJobOptions}
                    placeholder="Select sub job..."
                    isClearable
                  />
                </div>
                <div>
                  <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                    Sub Job Level (Auto-calculated)
                  </label>
                  <input
                    type="number"
                    min="1"
                    max="99"
                    value={subJobLevel}
                    disabled
                    className="w-full px-3 py-2 border border-gray-300 rounded-md bg-gray-100 text-gray-600 cursor-not-allowed dark:bg-gray-600 dark:border-gray-500 dark:text-gray-300"
                    placeholder="Auto-calculated"
                  />
                </div>
              </div>
            </div>

            {/* Gear Set Selection */}
            <div className="flex flex-col gap-4">
              <div className="flex-1">
                <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                  Gear Set *
                </label>
                <ReactSelector
                  value={
                    selectedGearSet
                      ? {
                          value: selectedGearSet.id?.toString() || '',
                          label: selectedGearSet.name
                        }
                      : null
                  }
                  onChange={(option) => {
                    if (option) {
                      const gearSet = savedGearSets.find(set => set.id?.toString() === option.value);
                      setSelectedGearSet(gearSet);
                    } else {
                      setSelectedGearSet(undefined);
                    }
                  }}
                  options={savedGearSets.map(set => ({
                    value: set.id?.toString() || '',
                    label: set.name
                  }))}
                  placeholder="Select a gear set..."
                  isClearable
                />
              </div>
            </div>

            {/* Submit Button */}
            <div className="flex justify-center">
              <button
                onClick={handleSubmit}
                disabled={!canSubmit}
                className={`px-8 py-3 rounded-lg font-medium transition-colors ${
                  canSubmit
                    ? 'bg-blue-600 hover:bg-blue-700 text-white cursor-pointer'
                    : 'bg-gray-300 text-gray-500 cursor-not-allowed dark:bg-gray-600 dark:text-gray-400'
                }`}
              >
                Start Simulation
              </button>
            </div>
          </div>
        )}
      </Card>

      {/* Debug Info */}
      {selectedJob && (
        <Card>
          <h3 className="font-semibold text-gray-800 dark:text-gray-200 mb-2">
            Current Selection:
          </h3>
          <p className="text-sm text-gray-600 dark:text-gray-400">
            Main Job: {selectedJob.fullName} ({selectedJob.abbreviation}){masterLevel !== undefined ? ` - Master Level ${masterLevel}` : ''}
            {selectedSubJob && (
              <span> | Sub Job: {selectedSubJob.fullName} ({selectedSubJob.abbreviation}) - Level {subJobLevel}</span>
            )}
            {selectedGearSet && (
              <span> | Gear Set: {selectedGearSet.name}</span>
            )}
          </p>
        </Card>
      )}
    </>
  );
}

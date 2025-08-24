import { ReactSelector } from "../components/ReactSelector";
import Card from "../components/Card";
import { useState, useEffect } from "react";
import type { Job } from "../models/Job";
import { useAppData } from "../contexts/AppDataContext";
import { GearSetBuilder } from "../components/GearSetBuilder";

const BuildGearSetPage = () => {
  const { jobs, loading: loadingAppData, error } = useAppData();

  const [selectedJob, setSelectedJob] = useState<Job | undefined>();
  const [selectedSubJob, setSelectedSubJob] = useState<Job | undefined>();

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
  };

  const handleSubJobChange = (option: any) => {
    setSelectedSubJob(jobs?.find((job) => job.abbreviation === option?.value));
  };

  return (
    <>
      <div className="flex justify-between items-center mb-4">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          Build Gear Set
        </h1>
      </div>
      <Card className="mb-4">
        {loadingAppData ? (
          <div className="text-gray-500">Loading...</div>
        ) : error ? (
          <div className="text-red-500">Error: {error}</div>
        ) : (
          <div className="flex flex-col gap-4 sm:flex-row sm:gap-8 sm:items-end">
            <div className="flex-1">
              <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
                Job
              </label>
              <ReactSelector
                value={jobOptions.find(
                  (opt) => opt.value === selectedJob?.abbreviation
                )}
                onChange={handleJobChange}
                options={jobOptions}
              />
            </div>
            <div className="flex items-center justify-center pb-2 sm:pb-2">
              <span className="text-4xl font-light text-gray-400 dark:text-gray-500 select-none">
                /
              </span>
            </div>
            <div className="flex-1">
              <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200 flex items-center gap-1">
                Sub Job
                <div className="relative group">
                  <svg
                    className="w-4 h-4 text-gray-400 hover:text-gray-600 dark:text-gray-500 dark:hover:text-gray-300 cursor-help"
                    fill="currentColor"
                    viewBox="0 0 20 20"
                  >
                    <path
                      fillRule="evenodd"
                      d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-8-3a1 1 0 00-.867.5 1 1 0 11-1.731-1A3 3 0 0113 8a3.001 3.001 0 01-2 2.83V11a1 1 0 11-2 0v-1a1 1 0 011-1 1 1 0 100-2zm0 8a1 1 0 100-2 1 1 0 000 2z"
                      clipRule="evenodd"
                    />
                  </svg>
                  <div className="absolute bottom-full left-1/2 transform -translate-x-1/2 mb-2 px-3 py-2 text-sm text-white bg-gray-900 rounded-lg opacity-0 group-hover:opacity-100 transition-opacity duration-200 pointer-events-none whitespace-nowrap z-10">
                    Sub job is used only to determine dual-wield capability
                    <div className="absolute top-full left-1/2 transform -translate-x-1/2 w-0 h-0 border-l-4 border-r-4 border-t-4 border-transparent border-t-gray-900"></div>
                  </div>
                </div>
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
              />
            </div>
          </div>
        )}
      </Card>
      {selectedJob && (
        <GearSetBuilder job={selectedJob} subJob={selectedSubJob} />
      )}
    </>
  );
};

export default BuildGearSetPage;

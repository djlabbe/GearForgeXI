import { ReactSelector } from "../components/ReactSelector";
import { GearSetComparer } from "../components/GearSetComparer";
import Card from "../components/Card";
import Notes from "../components/Notes";
import { useJobs } from "../contexts/JobsContext";
import { useState, useEffect } from "react";
import type { Job } from "../models/Job";

const ComparePage = () => {
  const { jobs, loading: loadingJobs, error } = useJobs();

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
      <Card className="mb-4">
        {loadingJobs ? (
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
              />
            </div>
          </div>
        )}
      </Card>
      {selectedJob && <GearSetComparer job={selectedJob} subJob={selectedSubJob} />}
      <Notes />
    </>
  );
};

export default ComparePage;

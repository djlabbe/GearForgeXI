import { ReactSelector } from "../components/ReactSelector";
import { GearSetComparer } from "../components/GearSetComparer";
import Card from "../components/Card";
import Notes from "../components/Notes";
import { useJobs } from "../contexts/JobsContext";
import { useState } from "react";
import type { Job } from "../models/Job";

const ComparePage = () => {
  const { jobs, loading: loadingJobs, error } = useJobs();

    const [selectedJob, setSelectedJob] = useState<Job | undefined>();
  

  const jobOptions =
    jobs?.map((job) => ({
      value: job.abbreviation,
      label: `${job.fullName} (${job.abbreviation})`,
    })) || [];

  return (
    <>
      <Card className="mb-4">
        {loadingJobs ? (
          <div className="text-gray-500">Loading...</div>
        ) : error ? (
          <div className="text-red-500">Error: {error}</div>
        ) : (
          <>
            <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">
              Job
            </label>

            <ReactSelector
              value={jobOptions.find(
                (opt) => opt.value === selectedJob?.abbreviation
              )}
              onChange={(option) =>
                setSelectedJob(
                  jobs?.find((job) => job.abbreviation === option?.value)
                )
              }
              options={jobOptions}
            />
          </>
        )}
      </Card>
      {selectedJob && <GearSetComparer job={selectedJob} />}
      <Notes />
    </>
  );
};

export default ComparePage;

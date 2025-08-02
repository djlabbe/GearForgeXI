import { useState, useEffect } from "react";
import { ReactSelector } from "../components/ReactSelector";
import { GearSetComparer } from "../components/GearSetComparer";
import Card from "../components/Card";
import Notes from "../components/Notes";
import type { Job } from "../models/Job";

const ComparePage = () => {
  const [jobs, setJobs] = useState<Job[]>();

  const [selectedJob, setSelectedJob] = useState<Job>();
  const [loadingJobs, setLoadingJobs] = useState<boolean>(false);

  const jobOptions =
    jobs?.map((job) => ({
      value: job.abbreviation,
      label: `${job.fullName} (${job.abbreviation})`,
    })) || [];

  useEffect(() => {
    setLoadingJobs(true);
    fetch("/api/jobs")
      .then((res) => res.json())
      .then((data: Job[]) => {
        setJobs(data);
      })
      .finally(() => setLoadingJobs(false));
  }, []);

  return (
    <>
      <Card className="mb-4">
        {loadingJobs ? (
          <div className="text-gray-500">Loading...</div>
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

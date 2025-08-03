import { createContext, useContext, useState, useEffect } from "react";
import type { ReactNode } from "react";
import type { Job } from "../models/Job";

interface JobsContextType {
  jobs: Job[];
  loading: boolean;
  error: string | null;
}

const JobsContext = createContext<JobsContextType | undefined>(undefined);

interface JobsProviderProps {
  children: ReactNode;
}

export const JobsProvider = ({ children }: JobsProviderProps) => {
  const [jobs, setJobs] = useState<Job[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchJobs = async () => {
      setLoading(true);
      setError(null);
      try {
        const response = await fetch("/api/jobs");
        if (!response.ok) {
          throw new Error(`Failed to fetch jobs: ${response.statusText}`);
        }
        const data: Job[] = await response.json();
        setJobs(data);
      } catch (err) {
        setError(err instanceof Error ? err.message : "Failed to load jobs");
      } finally {
        setLoading(false);
      }
    };

    fetchJobs();
  }, []);

  const value: JobsContextType = {
    jobs,
    loading,
    error,
  };

  return <JobsContext.Provider value={value}>{children}</JobsContext.Provider>;
};

export const useJobs = () => {
  const context = useContext(JobsContext);
  if (context === undefined) {
    throw new Error("useJobs must be used within a JobsProvider");
  }
  return context;
};

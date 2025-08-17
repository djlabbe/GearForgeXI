import { useState, useEffect } from 'react';
import Modal from './Modal';
import { JobsService, CharacterProfileService } from '../services';
import type { CharacterProfile, UpdateCharacterJobDto } from '../models/CharacterProfile';
import type { Job } from '../models/Job';

interface ManageJobsModalProps {
  profile: CharacterProfile;
  onClose: () => void;
  onUpdate: () => void;
}

interface JobForm {
  jobId: number;
  jobLevel: number;
  masterLevel: number;
}

export function ManageJobsModal({ profile, onClose, onUpdate }: ManageJobsModalProps) {
  const [jobs, setJobs] = useState<Job[]>([]);
  const [jobForms, setJobForms] = useState<JobForm[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [isSubmitting, setIsSubmitting] = useState(false);

  useEffect(() => {
    loadJobs();
  }, []);

  const loadJobs = async () => {
    try {
      setLoading(true);
      const allJobs = await JobsService.getJobs();
      setJobs(allJobs);
      
      // Initialize form data with existing character jobs
      const initialForms = allJobs.map(job => {
        const existingJob = profile.characterJobs.find(cj => cj.job.id === job.id);
        return {
          jobId: job.id,
          jobLevel: existingJob ? existingJob.jobLevel : 0,
          masterLevel: existingJob ? existingJob.masterLevel : 0,
        };
      });
      
      setJobForms(initialForms);
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to load jobs');
    } finally {
      setLoading(false);
    }
  };

  const updateJobForm = (jobId: number, field: 'jobLevel' | 'masterLevel', value: number) => {
    setJobForms(prev => prev.map(form => 
      form.jobId === jobId 
        ? { ...form, [field]: value }
        : form
    ));
  };

  const setAllJobsTo99 = () => {
    setJobForms(prev => prev.map(form => ({
      ...form,
      jobLevel: 99
    })));
  };

  const getJobsToUpdate = (): UpdateCharacterJobDto[] => {
    return jobForms
      .filter(form => {
        const existingJob = profile.characterJobs.find(cj => cj.job.id === form.jobId);
        // Include if it's a new job (level > 1) or if it's changed
        return form.jobLevel > 1 || 
               form.masterLevel > 0 || 
               (existingJob && (existingJob.jobLevel !== form.jobLevel || existingJob.masterLevel !== form.masterLevel));
      })
      .map(form => ({
        jobId: form.jobId,
        jobLevel: form.jobLevel,
        masterLevel: form.masterLevel,
      }));
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    
    const jobsToUpdate = getJobsToUpdate();
    
    setIsSubmitting(true);
    try {
      await CharacterProfileService.updateCharacterJobs(profile.id, jobsToUpdate);
      onUpdate();
      onClose();
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to update character jobs');
    } finally {
      setIsSubmitting(false);
    }
  };

  if (loading) {
    return (
      <Modal isOpen={true} onClose={onClose}>
        <div className="p-6 text-center">
          <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600 mx-auto mb-4"></div>
          <p>Loading jobs...</p>
        </div>
      </Modal>
    );
  }

  return (
    <Modal isOpen={true} onClose={onClose} size="md">
      <div className="p-4 space-y-6">
        <div>
          <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
            Manage Jobs - {profile.characterName}
          </h3>
          <p className="text-sm text-gray-600 dark:text-gray-400">
            Set job levels and master levels for your character:
          </p>
        </div>
        
        {error && (
          <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded dark:bg-red-900 dark:border-red-600 dark:text-red-200">
            {error}
          </div>
        )}

        <form onSubmit={handleSubmit}>
          {/* Header */}
          <div className="grid grid-cols-4 gap-4 p-3 bg-gray-50 dark:bg-gray-800 border border-gray-200 dark:border-gray-600 rounded-t-lg text-sm font-medium text-gray-700 dark:text-gray-300">
            <div>Job</div>
            <div>Level</div>
            <div>Master Level</div>
            <div>Current</div>
          </div>
          
          {/* Scrollable job rows */}
          <div className="max-h-80 overflow-y-auto border-l border-r border-b border-gray-200 dark:border-gray-600 rounded-b-lg">
            {jobs.map(job => {
              const form = jobForms.find(f => f.jobId === job.id)!;
              const existingJob = profile.characterJobs.find(cj => cj.job.id === job.id);
              
              return (
                <div 
                  key={job.id} 
                  className={`grid grid-cols-4 gap-4 p-3 border-b border-gray-100 dark:border-gray-700 last:border-b-0 hover:bg-gray-50 dark:hover:bg-gray-800 ${
                    existingJob ? 'bg-green-50 dark:bg-green-900/10' : ''
                  }`}
                >
                  {/* Job name */}
                  <div className="flex items-center">
                    <span className="font-medium text-gray-900 dark:text-gray-100" title={job.fullName}>
                      {job.abbreviation}
                    </span>
                  </div>
                  
                  {/* Job Level input */}
                  <div>
                    <input
                      type="number"
                      min="0"
                      max="99"
                      value={form.jobLevel}
                      onChange={(e) => updateJobForm(job.id, 'jobLevel', parseInt(e.target.value) || 0)}
                      className="w-20 px-2 py-1 text-sm border border-gray-300 dark:border-gray-600 rounded focus:outline-none focus:ring-1 focus:ring-blue-500 dark:bg-gray-700 dark:text-gray-100"
                    />
                  </div>
                  
                  {/* Master Level input */}
                  <div>
                    <input
                      type="number"
                      min="0"
                      max="50"
                      value={form.masterLevel}
                      onChange={(e) => updateJobForm(job.id, 'masterLevel', parseInt(e.target.value) || 0)}
                      className="w-20 px-2 py-1 text-sm border border-gray-300 dark:border-gray-600 rounded focus:outline-none focus:ring-1 focus:ring-blue-500 dark:bg-gray-700 dark:text-gray-100"
                    />
                  </div>
                  
                  {/* Current levels */}
                  <div className="flex items-center">
                    {existingJob ? (
                      <span className="text-sm text-green-600 dark:text-green-400">
                        {existingJob.jobLevel}{existingJob.masterLevel > 0 && `/${existingJob.masterLevel}`}
                      </span>
                    ) : (
                      <span className="text-sm text-gray-400">-</span>
                    )}
                  </div>
                </div>
              );
            })}
          </div>

          <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700 mt-6">
            {/* Left side - Quick actions */}
            <button
              type="button"
              onClick={setAllJobsTo99}
              disabled={isSubmitting}
              className="px-3 py-2 text-sm font-medium text-white bg-green-600 border border-transparent rounded-md hover:bg-green-700 focus:outline-none focus:ring-2 focus:ring-green-500 disabled:opacity-50 cursor-pointer disabled:cursor-not-allowed"
            >
              All Jobs 99
            </button>
            
            {/* Right side - Main actions */}
            <div className="flex space-x-2">
              <button
                type="button"
                onClick={onClose}
                disabled={isSubmitting}
                className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 disabled:opacity-50 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer disabled:cursor-not-allowed"
              >
                Cancel
              </button>
              <button
                type="submit"
                disabled={isSubmitting}
                className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 disabled:opacity-50 cursor-pointer disabled:cursor-not-allowed"
              >
                {isSubmitting ? (
                  <div className="flex items-center space-x-2">
                    <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                    <span>Updating...</span>
                  </div>
                ) : (
                  'Update Jobs'
                )}
              </button>
            </div>
          </div>
        </form>
      </div>
    </Modal>
  );
}

interface Props {
  selectedJob: string | null;
  onSelect: (job: string) => void;
  availableJobs: string[];
}

export function JobSelector({ selectedJob, onSelect, availableJobs }: Props) {
  return (
    <div className="mb-6">
      <label className="block font-semibold mb-1">Job</label>
      <select
        className="border p-2"
        value={selectedJob ?? ""}
        onChange={(e) => onSelect(e.target.value)}
      >
        <option value="">-- Choose Job --</option>
        {availableJobs.map((job) => (
          <option key={job} value={job}>
            {job.toUpperCase()}
          </option>
        ))}
      </select>
    </div>
  );
}

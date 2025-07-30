import Card from "./Card";

interface Props {
  selectedJob: string | null;
  onSelect: (job: string) => void;
  availableJobs: string[];
}

export function JobSelector({ selectedJob, onSelect, availableJobs }: Props) {
  return (
    <Card className="mb-3">
      <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">Job</label>
      <select
        className="border border-gray-300 dark:border-gray-600 p-2 bg-white text-gray-900 dark:bg-gray-700 dark:text-gray-100 rounded w-full"
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
    </Card>
  );
}

import ReactSelect from "react-select";
import Card from "./Card";

interface Props {
  selectedJob: string | null;
  onSelect: (job: string) => void;
  availableJobs: string[];
}

export function JobSelector({ selectedJob, onSelect, availableJobs }: Props) {

  const selectOptions = availableJobs.map((job) => ({
    value: job,
    label: job,
  }));

  const selectedOption = selectedJob
    ? { value: selectedJob, label: selectedJob }
    : null;

    const handleChange = (option: { value: string; label: string } | null) => {
      if (!option || option.value === "") {
        onSelect("");
        return;
      }
      onSelect(option.value);
    };

  return (
    <Card className="mb-3">
      <label className="block font-semibold mb-2 text-gray-800 dark:text-gray-200">Job</label>
      <ReactSelect
        className="text-gray-900 dark:text-gray-100"
        classNamePrefix="react-select"
        value={selectedOption || { value: "", label: "Select a job" }}
        onChange={handleChange}
        options={selectOptions}
        isClearable
        menuPlacement="auto"
        styles={{
          control: (base, state) => ({
            ...base,
            backgroundColor: state.isDisabled
              ? "rgba(243, 244, 246, 0.5)" // gray-100
              : "var(--tw-bg-opacity,1) #fff",
            borderColor: state.isFocused
              ? "#2563eb" // blue-600
              : "var(--tw-border-opacity,1) #d1d5db", // gray-300
            boxShadow: state.isFocused
              ? "0 0 0 1px #2563eb"
              : undefined,
            color: "var(--tw-text-opacity,1) #111827", // gray-900
            ...(window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches && {
                backgroundColor: "#1f2937", // gray-800
                borderColor: state.isFocused ? "#2563eb" : "#374151", // blue-600 or gray-700
                color: "#f3f4f6", // gray-100
              }),
          }),
          menu: (base) => ({
            ...base,
            backgroundColor:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#1f2937" // gray-800
                : "#fff",
            color:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#f3f4f6" // gray-100
                : "#111827", // gray-900
          }),
          option: (base, state) => ({
            ...base,
            backgroundColor: state.isSelected
              ? "#2563eb"
              : state.isFocused
              ? "rgba(37, 99, 235, 0.1)"
              : window.matchMedia &&
                window.matchMedia("(prefers-color-scheme: dark)").matches
              ? "#1f2937"
              : "#fff",
            color: state.isSelected
              ? "#fff"
              : window.matchMedia &&
                window.matchMedia("(prefers-color-scheme: dark)").matches
              ? "#f3f4f6"
              : "#111827",
          }),
          singleValue: (base) => ({
            ...base,
            color:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#f3f4f6"
                : "#111827",
          }),
          input: (base) => ({
            ...base,
            color:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#f3f4f6"
                : "#111827",
          }),
          placeholder: (base) => ({
            ...base,
            color:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#9ca3af" // gray-400
                : "#6b7280", // gray-500
          }),
          dropdownIndicator: (base) => ({
            ...base,
            color:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#9ca3af"
                : "#6b7280",
          }),
          clearIndicator: (base) => ({
            ...base,
            color:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#9ca3af"
                : "#6b7280",
          }),
        }}
      />
    </Card>
  );
}

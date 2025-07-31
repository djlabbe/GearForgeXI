import ReactSelect from "react-select";

interface Props {
  label: string;
  selected: string | null;
  onSelect: (value: string) => void;
  options: string[];
}

export function ReactSelector({ selected, onSelect, options }: Props) {

  const selectOptions = options.map((opt) => ({
    value: opt,
    label: opt,
  }));

  const selectedOption = selected
    ? { value: selected, label: selected }
    : null;

    const handleChange = (option: { value: string; label: string } | null) => {
      if (!option || option.value === "") {
        onSelect("");
        return;
      }
      onSelect(option.value);
    };

  return (
      <ReactSelect
        className="text-gray-900 dark:text-gray-100"
        classNamePrefix="react-select"
        value={selectedOption || { value: "", label: "Select..." }}
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
                backgroundColor: "#1e293b", // slate-800
                borderColor: state.isFocused ? "#2563eb" : "#374151", // blue-600 or gray-700
                color: "#f3f4f6", // gray-100
              }),
          }),
          menu: (base) => ({
            ...base,
            backgroundColor:
              window.matchMedia &&
              window.matchMedia("(prefers-color-scheme: dark)").matches
                ? "#1e293b" // slate-800
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
              ? "#1e293b"
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
  );
}

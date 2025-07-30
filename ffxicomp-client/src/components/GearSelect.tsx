import Select from "react-select";
import type { GearItem } from "../models/GearItem";

interface GearSelectProps {
  label: string;
  options: GearItem[];
  value?: GearItem;
  onChange: (item: GearItem | undefined) => void;
  placeholder?: string;
}

export function GearSelect({ 
  label, 
  options, 
  value, 
  onChange, 
  placeholder = "Select..." 
}: GearSelectProps) {
  const selectOptions = options.map((item) => ({
    value: String(item.id),
    label: item.name,
  }));

  const selectedOption = value 
    ? { value: String(value.id), label: value.name }
    : null;

  const handleChange = (option: { value: string; label: string } | null) => {
    if (!option || option.value === "") {
      onChange(undefined);
      return;
    }

    const item = options.find((g) => g.id === Number(option.value));
    onChange(item);
  };

  return (
    <div className="p-2">
      <label className="block capitalize mb-1">{label}</label>
      <Select
        options={[{ value: "", label: placeholder }, ...selectOptions]}
        value={selectedOption || { value: "", label: placeholder }}
        onChange={handleChange}
        isClearable
        classNamePrefix="react-select"
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
    </div>
  );
}

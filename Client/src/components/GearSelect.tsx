import type { GearItem } from "../models/GearItem";
import { ReactSelector } from "./ReactSelector";

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
  placeholder = "Select...",
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
    <div className="p-2 my-2">
      <label className="text-xs block font-semibold capitalize mb-1">{label}</label>
      <ReactSelector
        options={selectOptions}
        value={selectedOption}
        onChange={handleChange}
        placeholder={placeholder}
        isClearable
      />
    </div>
  );
}

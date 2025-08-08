import type { GearItem } from "../models/GearItem";
import { ReactSelector } from "./ReactSelector";
import { VerifiedGearOption, VerifiedGearSingleValue } from "./VerifiedGearOption";

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
    verified: item.verified || false,
    rank: item.rank,
    path: item.path,
  }));

  const selectedOption = value
    ? { 
        value: String(value.id), 
        label: value.name,
        verified: value.verified || false,
        rank: value.rank,
        path: value.path,
      }
    : null;

  const handleChange = (option: { value: string; label: string; verified?: boolean; rank?: number; path?: string } | null) => {
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
        components={{
          Option: VerifiedGearOption,
          SingleValue: VerifiedGearSingleValue,
        }}
      />
    </div>
  );
}

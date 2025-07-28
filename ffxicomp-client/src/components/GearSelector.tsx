import type { GearItem } from "../models/GearItem";

function GearSelector({
  label,
  items,
  selectedId,
  onChange,
}: {
  label: string;
  items: GearItem[];
  selectedId: number | null;
  onChange: (id: number) => void;
}) {
  return (
    <div>
      <label>{label}</label>
      <select
        value={selectedId ?? ""}
        onChange={(e) => onChange(Number(e.target.value))}
      >
        <option value="">Select Gear</option>
        {items.map((item) => (
          <option key={item.id} value={item.id}>
            {item.name}
          </option>
        ))}
      </select>
    </div>
  );
}

export default GearSelector;

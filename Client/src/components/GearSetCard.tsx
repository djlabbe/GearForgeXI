import { getItemAtPosition } from "../models/GearSet";
import { getItemsBySlot } from "../utils/gearFiltering";
import { ALL_GEAR_POSITIONS, type GearSetPosition } from "../models/GearSetPosition";
import type { GearItem } from "../models/GearItem";
import type { GearSet } from "../models/GearSet";
import type { GearStat } from "../models/GearStat";
import type { Job } from "../models/Job";
import { GearSelect } from "./GearSelect";
import Card from "./Card";
import AmbuCape, { ambuCapes } from "./AmbuCape";
import { GearSetControls } from "./GearSetControls";

interface GearSetCardProps {
  gearSet: GearSet;
  augments: GearStat[];
  gearItems: GearItem[];
  job: Job;
  subJob?: Job;
  isAuthenticated: boolean;
  setName: string;
  onSelect: (slot: GearSetPosition, item: GearItem | undefined) => void;
  onAugmentChange: (augments: GearStat[]) => void;
  onCreateNew: () => void;
  onUpdate: () => void;
  onLoad: () => void;
  onClear: () => void;
  onCopyLua: (gearSet: GearSet, augments: GearStat[]) => void;
}

export function GearSetCard({
  gearSet,
  augments,
  gearItems,
  job,
  subJob,
  isAuthenticated,
  setName,
  onSelect,
  onAugmentChange,
  onCreateNew,
  onUpdate,
  onLoad,
  onClear,
  onCopyLua,
}: GearSetCardProps) {
  const displayName = gearSet.id && gearSet.name !== setName 
    ? `${setName} - ${gearSet.name}` 
    : setName;

  const backItem = getItemAtPosition(gearSet, "Back");
  const showAmbuCape = backItem?.name && ambuCapes.includes(backItem.name);

  return (
    <Card className="relative">
      <GearSetControls
        gearSet={gearSet}
        augments={augments}
        isAuthenticated={isAuthenticated}
        onCreateNew={onCreateNew}
        onUpdate={onUpdate}
        onLoad={onLoad}
        onClear={onClear}
        onCopyLua={onCopyLua}
      />
      
      <h3 className="font-semibold mb-2">{displayName}</h3>
      
      <div className="grid grid-cols-1 md:grid-cols-4">
        {ALL_GEAR_POSITIONS.map((slot) => {
          const options = getItemsBySlot(gearItems, gearSet, slot, job, subJob);
          const selectedItem = getItemAtPosition(gearSet, slot);

          return (
            <GearSelect
              key={slot}
              label={slot}
              options={options}
              value={selectedItem || undefined}
              onChange={(item) => onSelect(slot, item)}
            />
          );
        })}
      </div>
      
      {showAmbuCape && (
        <AmbuCape onAugmentChange={onAugmentChange} />
      )}
    </Card>
  );
}

import { useState, useEffect } from "react";
import { ReactSelector } from "./ReactSelector";
import type { GearStat } from "../models/GearStat";


export const ambuCapes = [
    "Cichol's Mantle",
    "Segomo's Mantle",
    "Alaunus's Cape",
    "Taranus's Cape",
    "Sucellos's Cape",
    "Toutatis's Cape",
    "Rudianos's Mantle",
    "Ankou's Mantle",
    "Artio's Mantle",
    "Intarabus's Cape",
    "Belenus's Cape",
    "Smertrios's Mantle",
    "Andartia's Mantle",
    "Brigantia's Mantle",
    "Campestres's Cape",
    "Rosmerta's Cape",
    "Camulus's Mantle",
    "Visucius's Mantle",
    "Senuna's Mantle",
    "Lugh's Cape",
    "Nantosuelta's Cape",
    "Ogma's cape",
  ];

interface CapeOption {
  label: string;
  stats: GearStat[];
}

interface AmbuCapeProps {
  onAugmentChange: (augmentStats: GearStat[]) => void;
}

const threadOptions: CapeOption[] = [
  { label: "HP", stats: [{ name: "HP", value: 60 }] },
  { label: "MP", stats: [{ name: "MP", value: 60 }] },
  { label: "STR", stats: [{ name: "Str", value: 20 }] },
  { label: "DEX", stats: [{ name: "Dex", value: 20 }] },
  { label: "VIT", stats: [{ name: "Vit", value: 20 }] },
  { label: "AGI", stats: [{ name: "Agi", value: 20 }] },
  { label: "INT", stats: [{ name: "Int", value: 20 }] },
  { label: "MND", stats: [{ name: "Mnd", value: 20 }] },
  { label: "CHR", stats: [{ name: "Chr", value: 20 }] },
  {
    label: "Pet: Accuracy/Attack",
    stats: [
      { name: "Pet:Accuracy", value: 20 },
      { name: "Pet:RangedAccuracy", value: 20 },
      { name: "Pet:Attack", value: 20 },
      { name: "Pet:RangedAttack", value: 20 },
    ],
  },
  {
    label: "Pet: Magic Accuracy/Damage",
    stats: [
      { name: "Pet:MagicAccuracy", value: 20 },
      { name: "Pet:MagicDamage", value: 20 },
    ],
  },
];

const dustOptions: CapeOption[] = [
  {
    label: "Accuracy/Attack",
    stats: [
      { name: "Accuracy", value: 20 },
      { name: "Attack", value: 20 },
    ],
  },
  {
    label: "RangedAccuracy/RangedAttack",
    stats: [
      { name: "RangedAccuracy", value: 20 },
      { name: "RangedAttack", value: 20 },
    ],
  },
  {
    label: "MagicAccuracy/MagicDamage",
    stats: [
      { name: "MagicAccuracy", value: 20 },
      { name: "MagicDamage", value: 20 },
    ],
  },
  {
    label: "Evasion/MagicEvasion",
    stats: [
      { name: "Evasion", value: 20 },
      { name: "MagicEvasion", value: 20 },
    ],
  },
];

const sapOptions: CapeOption[] = [
  {
    label: "Weaponskill Damage",
    stats: [{ name: "WeaponSkillDamage", value: 10 }],
  },
  { label: "Critical Hit Rate", stats: [{ name: "CritRate", value: 10 }] },
  { label: "Store TP", stats: [{ name: "StoreTP", value: 10 }] },
  { label: "Double Attack", stats: [{ name: "DA", value: 10 }] },
  { label: "Haste", stats: [{ name: "GearHaste", value: 10 }] },
  { label: "Dual Wield", stats: [{ name: "DualWield", value: 10 }] },
  { label: "Enmity +", stats: [{ name: "EnmityPlus", value: 10 }] },
  { label: "Enmity -", stats: [{ name: "EnmityMinus", value: -10 }] },
  { label: "Snapshot", stats: [{ name: "Snapshot", value: 10 }] },
  { label: "Magic Attack", stats: [{ name: "MagicAttack", value: 10 }] },
  { label: "Fast Cast", stats: [{ name: "FastCast", value: 10 }] },
  { label: "Cure Potency", stats: [{ name: "CurePotency", value: 10 }] },
  { label: "Waltz Potency", stats: [{ name: "WaltzPotency", value: 10 }] },
  { label: "Pet: Regen", stats: [{ name: "Pet:Regen", value: 10 }] },
  { label: "Pet: Haste", stats: [{ name: "Pet:Haste", value: 10 }] },
];

const dyeOptions: CapeOption[] = [
  { label: "HP", stats: [{ name: "HP", value: 20 }] },
  { label: "MP", stats: [{ name: "MP", value: 20 }] },
  { label: "STR", stats: [{ name: "Str", value: 10 }] },
  { label: "DEX", stats: [{ name: "Dex", value: 10 }] },
  { label: "VIT", stats: [{ name: "Vit", value: 10 }] },
  { label: "AGI", stats: [{ name: "Agi", value: 10 }] },
  { label: "INT", stats: [{ name: "Int", value: 10 }] },
  { label: "MND", stats: [{ name: "Mnd", value: 10 }] },
  { label: "CHR", stats: [{ name: "Chr", value: 10 }] },
  { label: "Accuracy", stats: [{ name: "Accuracy", value: 10 }] },
  { label: "Attack", stats: [{ name: "Attack", value: 10 }] },
  { label: "Ranged Accuracy", stats: [{ name: "RangedAccuracy", value: 10 }] },
  { label: "Ranged Attack", stats: [{ name: "RangedAttack", value: 10 }] },
  { label: "Magic Accuracy", stats: [{ name: "MagicAccuracy", value: 10 }] },
  { label: "Magic Damage", stats: [{ name: "MagicDamage", value: 10 }] },
  { label: "Evasion", stats: [{ name: "Evasion", value: 10 }] },
  { label: "Magic Evasion", stats: [{ name: "MagicEvasion", value: 20 }] },
  {
    label: "Pet: Accuracy/Ranged Accuracy",
    stats: [
      { name: "Pet:Accuracy", value: 20 },
      { name: "Pet:RangedAccuracy", value: 20 },
    ],
  },
  {
    label: "Pet: Attack/Ranged Attack",
    stats: [
      { name: "Pet:Attack", value: 20 },
      { name: "Pet:RangedAttack", value: 20 },
    ],
  },
  {
    label: "Pet: Magic Accuracy",
    stats: [{ name: "Pet:MagicAccuracy", value: 20 }],
  },
  {
    label: "Pet: Magic Damage",
    stats: [{ name: "Pet:MagicDamage", value: 20 }],
  },
];

const resinOptions: CapeOption[] = [
  { label: "Defense", stats: [{ name: "Defense", value: 50 }] },
  { label: "Evasion", stats: [{ name: "Evasion", value: 15 }] },
  { label: "Magic Evasion", stats: [{ name: "MagicEvasion", value: 15 }] },
  { label: "Physical damage taken", stats: [{ name: "PDT", value: -10 }] },
  { label: "Magic damage taken", stats: [{ name: "MDT", value: -10 }] },
  { label: "Damage taken", stats: [{ name: "DT", value: -5 }] },
  { label: "Regen", stats: [{ name: "Regen", value: 5 }] },
  { label: "Counter", stats: [{ name: "Counter", value: 10 }] },
  { label: "Blocking rate", stats: [{ name: "BlockRate", value: 5 }] },
  { label: "Parrying rate", stats: [{ name: "ParryRate", value: 5 }] },
  {
    label: "Status ailment resistance",
    stats: [{ name: "StatusResist", value: 10 }],
  },
  { label: "Casting interruption rate", stats: [{ name: "SIRD", value: -10 }] },
  {
    label: "Pet: Physical damage taken",
    stats: [{ name: "Pet:PDT", value: -10 }],
  },
  {
    label: "Pet: Magic damage taken",
    stats: [{ name: "Pet:MDT", value: -10 }],
  },
  { label: "Pet: Damage taken", stats: [{ name: "Pet:DT", value: -5 }] },
  { label: "Pet: Regen", stats: [{ name: "Pet:Regen", value: 5 }] },
];

const AmbuCape = ({ onAugmentChange }: AmbuCapeProps) => {
  const [selectedThread, setSelectedThread] = useState<CapeOption | null>(null);
  const [selectedDust, setSelectedDust] = useState<CapeOption | null>(null);
  const [selectedDye, setSelectedDye] = useState<CapeOption | null>(null);
  const [selectedSap, setSelectedSap] = useState<CapeOption | null>(null);
  const [selectedResin, setSelectedResin] = useState<CapeOption | null>(null);

  // Update the augment stats whenever selections change
  useEffect(() => {
    const augmentStats: GearStat[] = [];

    if (selectedThread) augmentStats.push(...selectedThread.stats);
    if (selectedDust) augmentStats.push(...selectedDust.stats);
    if (selectedDye) augmentStats.push(...selectedDye.stats);
    if (selectedSap) augmentStats.push(...selectedSap.stats);
    if (selectedResin) augmentStats.push(...selectedResin.stats);

    onAugmentChange(augmentStats);
  }, [
    selectedThread,
    selectedDust,
    selectedDye,
    selectedSap,
    selectedResin,
    onAugmentChange,
  ]);

  return (
    <div className="grid grid-cols-4">
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Thread</label>
        <ReactSelector
          options={threadOptions.map((option) => option.label)}
          value={selectedThread?.label || ""}
          onChange={(value) =>
            setSelectedThread(
              threadOptions.find((opt) => opt.label === value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Dust</label>
        <ReactSelector
          options={dustOptions.map((option) => option.label)}
          value={selectedDust?.label || ""}
          onChange={(value) =>
            setSelectedDust(
              dustOptions.find((opt) => opt.label === value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Sap</label>
        <ReactSelector
          options={sapOptions.map((option) => option.label)}
          value={selectedSap?.label || ""}
          onChange={(value) =>
            setSelectedSap(
              sapOptions.find((opt) => opt.label === value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Dye</label>
        <ReactSelector
          options={dyeOptions.map((option) => option.label)}
          value={selectedDye?.label || ""}
          onChange={(value) =>
            setSelectedDye(
              dyeOptions.find((opt) => opt.label === value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Resin</label>
        <ReactSelector
          options={resinOptions.map((option) => option.label)}
          value={selectedResin?.label || ""}
          onChange={(value) =>
            setSelectedResin(
              resinOptions.find((opt) => opt.label === value) || null
            )
          }
        />
      </div>
    </div>
  );
};

export default AmbuCape;

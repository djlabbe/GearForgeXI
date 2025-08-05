import { useState, useEffect } from "react";
import { ReactSelector } from "./ReactSelector";
import type { GearStat } from "../models/GearStat";
import { useAppData } from "../contexts/AppDataContext";
import type { CapeOption } from "../contexts/AppDataContext";

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

interface AmbuCapeProps {
  onAugmentChange: (augmentStats: GearStat[]) => void;
}

const AmbuCape = ({ onAugmentChange }: AmbuCapeProps) => {
  const { threadOptions, dustOptions, sapOptions, dyeOptions, resinOptions } = useAppData();
  
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
          isClearable
          options={threadOptions.map((option) => ({
            value: option.label,
            label: option.label,
          }))}
          value={
            selectedThread
              ? { value: selectedThread.label, label: selectedThread.label }
              : null
          }
          onChange={(option) =>
            setSelectedThread(
              threadOptions.find((opt) => opt.label === option?.value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Dust</label>
        <ReactSelector
          isClearable
          options={dustOptions.map((option) => ({
            value: option.label,
            label: option.label,
          }))}
          value={
            selectedDust
              ? { value: selectedDust.label, label: selectedDust.label }
              : null
          }
          onChange={(option) =>
            setSelectedDust(
              dustOptions.find((opt) => opt.label === option?.value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Sap</label>
        <ReactSelector
          isClearable
          options={sapOptions.map((option) => ({
            value: option.label,
            label: option.label,
          }))}
          value={
            selectedSap
              ? { value: selectedSap.label, label: selectedSap.label }
              : null
          }
          onChange={(option) =>
            setSelectedSap(
              sapOptions.find((opt) => opt.label === option?.value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Dye</label>
        <ReactSelector
          isClearable
          options={dyeOptions.map((option) => ({
            value: option.label,
            label: option.label,
          }))}
          value={
            selectedDye
              ? { value: selectedDye.label, label: selectedDye.label }
              : null
          }
          onChange={(option) =>
            setSelectedDye(
              dyeOptions.find((opt) => opt.label === option?.value) || null
            )
          }
        />
      </div>
      <div className="p-2">
        <label className="block capitalize mb-1">Cape Resin</label>
        <ReactSelector
          isClearable
          options={resinOptions.map((option) => ({
            value: option.label,
            label: option.label,
          }))}
          value={
            selectedResin
              ? { value: selectedResin.label, label: selectedResin.label }
              : null
          }
          onChange={(option) =>
            setSelectedResin(
              resinOptions.find((opt) => opt.label === option?.value) || null
            )
          }
        />
      </div>
    </div>
  );
};

export default AmbuCape;

import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import AddJobBaseStatModal from "./AddJobBaseStatModal";

import type { CellValueChangedEvent, ColDef } from "ag-grid-community";
import type { JobBaseStat } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface JobBaseStatsGridProps {
  jobBaseStats: JobBaseStat[];
  onJobBaseStatsChange: (newJobBaseStats: JobBaseStat[]) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
}

export function JobBaseStatsGrid({
  jobBaseStats,
  onJobBaseStatsChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
}: JobBaseStatsGridProps) {
  const [isAddBaseStatModalOpen, setIsAddBaseStatModalOpen] = useState(false);

  // Column definitions for Job Base Stats
  const baseStatsColumnDefs: ColDef<JobBaseStat>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 150,
      editable: false,
      valueGetter: (params) =>
        params.data?.stat?.displayName || params.data?.stat?.name,
    },
    {
      headerName: "Value",
      field: "value",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
      cellEditorPopup: false,
      cellEditor: "agNumberCellEditor",
      cellEditorParams: {
        min: 0,
        max: 999,
        precision: 0,
      },
      valueSetter: (params) => {
        const newValue = parseInt(params.newValue);
        if (isNaN(newValue) || newValue < 0 || newValue > 999) {
          return false; // Reject invalid values
        }
        params.data.value = newValue;
        return true;
      },
    },
  ];

  const handleAddBaseStat = () => {
    setIsAddBaseStatModalOpen(true);
  };

  const handleJobBaseStatCreated = (newJobBaseStat: JobBaseStat) => {
    const updatedJobBaseStats = [...jobBaseStats, newJobBaseStat];
    onJobBaseStatsChange(updatedJobBaseStats);
  };

  const getExistingBaseStatIds = (): number[] => {
    return jobBaseStats.map((baseStat) => baseStat.statId);
  };

  const handleBaseStatCellValueChanged = async (
    event: CellValueChangedEvent<JobBaseStat>
  ) => {
    const updatedStat = event.data;
    try {
      await JobConfigurationsService.updateJobBaseStat(
        jobConfigurationId,
        updatedStat.id,
        updatedStat.value
      );
      console.log("Stat updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update stat. Please try again.");
    }
  };

  return (
    <>
      <div className="space-y-2">
        <div className="flex justify-between items-center">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Base Stats ({jobBaseStats.length})
          </h3>
          {isAdmin && (
            <button
              onClick={handleAddBaseStat}
              className="px-3 py-1 text-sm bg-blue-600 hover:bg-blue-700 text-white rounded-md transition-colors duration-200 font-medium cursor-pointer"
            >
              Add Base Stat
            </button>
          )}
        </div>
        <div
          className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
          style={{ height: 300, width: "100%" }}
        >
          <AgGridReact<JobBaseStat>
            theme={isDarkMode ? themeDarkBlue : themeAlpine}
            rowData={jobBaseStats}
            columnDefs={baseStatsColumnDefs}
            onCellValueChanged={handleBaseStatCellValueChanged}
            defaultColDef={{
              resizable: true,
              sortable: true,
              filter: true,
            }}
          />
        </div>
      </div>

      {/* Add Job Base Stat Modal */}
      <AddJobBaseStatModal
        isOpen={isAddBaseStatModalOpen}
        onClose={() => setIsAddBaseStatModalOpen(false)}
        onJobBaseStatCreated={handleJobBaseStatCreated}
        jobConfigurationId={jobConfigurationId}
        existingStatIds={getExistingBaseStatIds()}
      />
    </>
  );
}

export default JobBaseStatsGrid;

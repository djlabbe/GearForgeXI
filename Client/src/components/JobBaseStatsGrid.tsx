import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import AddJobBaseStatModal from "./AddJobBaseStatModal";
import ConfirmationModal from "./ConfirmationModal";

import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";
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
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [baseStatToDelete, setBaseStatToDelete] = useState<{
    statId: number;
    statName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);

  // Column definitions for Job Base Stats
  const baseStatsColumnDefs: ColDef<JobBaseStat>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Stat ID",
      field: "stat.id",
      width: 150,
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
    {
      headerName: "Actions",
      width: 120,
      sortable: false,
      filter: false,
      editable: false,
      cellRenderer: (params: ICellRendererParams<JobBaseStat>) => {
        const baseStat = params.data;
        if (!baseStat) return null;

        const statName =
          baseStat.stat?.displayName ||
          baseStat.stat?.name ||
          `Stat ID ${baseStat.statId}`;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() => handleDeleteBaseStat(baseStat.statId, statName)}
                className="p-2 text-red-400 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                title={`Delete ${statName}`}
              >
                <svg
                  className="h-4 w-4"
                  fill="none"
                  stroke="currentColor"
                  viewBox="0 0 24 24"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16"
                  />
                </svg>
              </button>
            )}
          </div>
        );
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
        updatedStat.statId,
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

  const handleDeleteBaseStat = (statId: number, statName: string) => {
    setBaseStatToDelete({ statId, statName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteBaseStat = async () => {
    if (!baseStatToDelete) return;

    setIsDeleting(true);
    try {
      await JobConfigurationsService.deleteJobBaseStat(
        jobConfigurationId,
        baseStatToDelete.statId
      );

      // Update the local state by removing the deleted base stat
      const updatedJobBaseStats = jobBaseStats.filter(
        (baseStat) => baseStat.statId !== baseStatToDelete.statId
      );
      onJobBaseStatsChange(updatedJobBaseStats);

      setShowDeleteConfirm(false);
      setBaseStatToDelete(null);
      console.log("Base stat deleted successfully");
    } catch (error) {
      console.error("Error deleting base stat:", error);
      alert("Failed to delete base stat. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteBaseStat = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setBaseStatToDelete(null);
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

      {/* Confirmation Modal for Deletion */}
      {showDeleteConfirm && baseStatToDelete && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          onConfirm={confirmDeleteBaseStat}
          onCancel={cancelDeleteBaseStat}
          title="Delete Base Stat"
          message={`Are you sure you want to delete the base stat "${baseStatToDelete.statName}"? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
        />
      )}
    </>
  );
}

export default JobBaseStatsGrid;

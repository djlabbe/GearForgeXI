import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import AddJobTraitModal from "./AddJobTraitModal";
import ConfirmationModal from "./ConfirmationModal";

import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";
import type { JobTrait } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface JobTraitsGridProps {
  jobTraits: JobTrait[];
  onJobTraitsChange: (newJobTraits: JobTrait[]) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
  height?: number;
}

export function JobTraitsGrid({
  jobTraits,
  onJobTraitsChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
  height = 400,
}: JobTraitsGridProps) {
  const [isAddTraitModalOpen, setIsAddTraitModalOpen] = useState(false);
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [traitToDelete, setTraitToDelete] = useState<{
    traitId: number;
    traitName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);
  // Column definitions for Job Traits
  const traitsColumnDefs: ColDef<JobTrait>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Name",
      field: "name",
      width: 250,
      editable: isAdmin,
      enableCellChangeFlash: true,
    },
    {
      headerName: "Level",
      field: "level",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
      cellEditor: "agNumberCellEditor",
      cellEditorParams: {
        min: 1,
        max: 99,
        precision: 0,
      },
      valueSetter: (params) => {
        const newValue = parseInt(params.newValue);
        if (isNaN(newValue) || newValue < 1 || newValue > 99) {
          return false; // Reject invalid values
        }
        params.data.level = newValue;
        return true;
      },
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 300,
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
      cellEditor: "agNumberCellEditor",
      cellEditorParams: {
        min: -999,
        max: 999,
        precision: 0,
      },
      valueSetter: (params) => {
        const newValue = parseInt(params.newValue);
        if (isNaN(newValue) || newValue < -999 || newValue > 999) {
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
      cellRenderer: (params: ICellRendererParams<JobTrait>) => {
        const trait = params.data;
        if (!trait) return null;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() => handleDeleteTrait(trait.id, trait.name)}
                className="p-2 text-red-400 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                title={`Delete ${trait.name}`}
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

  const handleAddTrait = () => {
    setIsAddTraitModalOpen(true);
  };

  const handleJobTraitCreated = (newJobTrait: JobTrait) => {
    const updatedJobTraits = [...jobTraits, newJobTrait];
    onJobTraitsChange(updatedJobTraits);
  };

  const handleTraitCellValueChanged = async (
    event: CellValueChangedEvent<JobTrait>
  ) => {
    const updatedTrait = event.data;
    try {
      await JobConfigurationsService.updateJobTrait(
        jobConfigurationId,
        updatedTrait.id,
        {
          name: updatedTrait.name,
          level: updatedTrait.level,
          statId: updatedTrait.statId,
          value: updatedTrait.value,
        }
      );
      console.log("Trait updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update trait. Please try again.");
    }
  };

  const handleDeleteTrait = (traitId: number, traitName: string) => {
    setTraitToDelete({ traitId, traitName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteTrait = async () => {
    if (!traitToDelete) return;

    setIsDeleting(true);
    try {
      await JobConfigurationsService.deleteJobTrait(
        jobConfigurationId,
        traitToDelete.traitId
      );

      // Update the local state by removing the deleted trait
      const updatedJobTraits = jobTraits.filter(
        (trait) => trait.id !== traitToDelete.traitId
      );
      onJobTraitsChange(updatedJobTraits);

      setShowDeleteConfirm(false);
      setTraitToDelete(null);
      console.log("Trait deleted successfully");
    } catch (error) {
      console.error("Error deleting trait:", error);
      alert("Failed to delete trait. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteTrait = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setTraitToDelete(null);
  };

  return (
    <>
      <div className="space-y-2">
        <div className="flex justify-between items-center">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Job Traits ({jobTraits.length})
          </h3>
          {isAdmin && (
            <button
              onClick={handleAddTrait}
              className="px-3 py-1 text-sm bg-blue-600 hover:bg-blue-700 text-white rounded-md transition-colors duration-200 font-medium cursor-pointer"
            >
              Add Trait
            </button>
          )}
        </div>
        <div
          className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
          style={{ height, width: "100%" }}
        >
          <AgGridReact<JobTrait>
            theme={isDarkMode ? themeDarkBlue : themeAlpine}
            rowData={jobTraits}
            columnDefs={traitsColumnDefs}
            onCellValueChanged={handleTraitCellValueChanged}
            defaultColDef={{
              resizable: true,
              sortable: true,
              filter: true,
            }}
          />
        </div>
      </div>

      {/* Add Job Trait Modal */}
      <AddJobTraitModal
        isOpen={isAddTraitModalOpen}
        onClose={() => setIsAddTraitModalOpen(false)}
        onJobTraitCreated={handleJobTraitCreated}
        jobConfigurationId={jobConfigurationId}
      />

      {/* Confirmation Modal for Deletion */}
      {showDeleteConfirm && traitToDelete && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          onConfirm={confirmDeleteTrait}
          onCancel={cancelDeleteTrait}
          title="Delete Job Trait"
          message={`Are you sure you want to delete the trait "${traitToDelete.traitName}"? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
        />
      )}
    </>
  );
}

export default JobTraitsGrid;

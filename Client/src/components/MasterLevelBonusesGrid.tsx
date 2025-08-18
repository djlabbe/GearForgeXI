import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import AddMasterLevelBonusModal from "./AddMasterLevelBonusModal";
import ConfirmationModal from "./ConfirmationModal";

import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";
import type { MasterLevelBonus } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface MasterLevelBonusesGridProps {
  masterLevelBonuses: MasterLevelBonus[];
  onMasterLevelBonusesChange: (
    newMasterLevelBonuses: MasterLevelBonus[]
  ) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
}

export function MasterLevelBonusesGrid({
  masterLevelBonuses,
  onMasterLevelBonusesChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
}: MasterLevelBonusesGridProps) {
  const [isAddMasterLevelBonusModalOpen, setIsAddMasterLevelBonusModalOpen] =
    useState(false);
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [bonusToDelete, setBonusToDelete] = useState<{
    statId: number;
    statName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);

  // Column definitions for Master Level Bonuses
  const mlBonusesColumnDefs: ColDef<MasterLevelBonus>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Stat",
      field: "stat.displayName",
      width: 200,
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
        min: 1,
        max: 999,
        precision: 0,
      },
      valueSetter: (params) => {
        const newValue = parseInt(params.newValue);
        if (isNaN(newValue) || newValue < 1 || newValue > 999) {
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
      cellRenderer: (params: ICellRendererParams<MasterLevelBonus>) => {
        const bonus = params.data;
        if (!bonus) return null;

        const statName =
          bonus.stat?.displayName ||
          bonus.stat?.name ||
          `Stat ID ${bonus.statId}`;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() => handleDeleteBonus(bonus.statId, statName)}
                className="p-2 text-red-400 hover:text-red-600 hover:bg-red-50 dark:hover:bg-red-900/20 rounded transition-colors duration-200"
                title={`Delete ${statName} bonus`}
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

  const handleAddMasterLevelBonus = () => {
    setIsAddMasterLevelBonusModalOpen(true);
  };

  const handleMasterLevelBonusCreated = (
    newMasterLevelBonus: MasterLevelBonus
  ) => {
    const updatedMasterLevelBonuses = [
      ...masterLevelBonuses,
      newMasterLevelBonus,
    ];
    onMasterLevelBonusesChange(updatedMasterLevelBonuses);
  };

  const getExistingBonusStatIds = (): number[] => {
    return masterLevelBonuses.map((bonus) => bonus.statId);
  };

  const handleMasterLevelBonusCellValueChanged = async (
    event: CellValueChangedEvent<MasterLevelBonus>
  ) => {
    const updatedBonus = event.data;
    try {
      await JobConfigurationsService.updateMasterLevelBonus(
        jobConfigurationId,
        updatedBonus.statId,
        updatedBonus.value
      );
      console.log("Master level bonus updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update master level bonus. Please try again.");
    }
  };

  const handleDeleteBonus = (statId: number, statName: string) => {
    setBonusToDelete({ statId, statName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteBonus = async () => {
    if (!bonusToDelete) return;

    setIsDeleting(true);
    try {
      await JobConfigurationsService.deleteMasterLevelBonus(
        jobConfigurationId,
        bonusToDelete.statId
      );

      // Update the local state by removing the deleted bonus
      const updatedMasterLevelBonuses = masterLevelBonuses.filter(
        (bonus) => bonus.statId !== bonusToDelete.statId
      );
      onMasterLevelBonusesChange(updatedMasterLevelBonuses);

      setShowDeleteConfirm(false);
      setBonusToDelete(null);
      console.log("Master level bonus deleted successfully");
    } catch (error) {
      console.error("Error deleting master level bonus:", error);
      alert("Failed to delete master level bonus. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteBonus = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setBonusToDelete(null);
  };

  return (
    <>
      <div className="space-y-2">
        <div className="flex justify-between items-center">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Master Level Bonuses ({masterLevelBonuses.length})
          </h3>
          {isAdmin && (
            <button
              onClick={handleAddMasterLevelBonus}
              className="px-3 py-1 text-sm bg-blue-600 hover:bg-blue-700 text-white rounded-md transition-colors duration-200 font-medium cursor-pointer"
            >
              Add Master Level Bonus
            </button>
          )}
        </div>
        <div
          className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
          style={{ height: 300, width: "100%" }}
        >
          <AgGridReact<MasterLevelBonus>
            theme={isDarkMode ? themeDarkBlue : themeAlpine}
            rowData={masterLevelBonuses}
            columnDefs={mlBonusesColumnDefs}
            onCellValueChanged={handleMasterLevelBonusCellValueChanged}
            defaultColDef={{
              resizable: true,
              sortable: true,
              filter: true,
            }}
          />
        </div>
      </div>

      {/* Add Master Level Bonus Modal */}
      <AddMasterLevelBonusModal
        isOpen={isAddMasterLevelBonusModalOpen}
        onClose={() => setIsAddMasterLevelBonusModalOpen(false)}
        onMasterLevelBonusCreated={handleMasterLevelBonusCreated}
        jobConfigurationId={jobConfigurationId}
        existingStatIds={getExistingBonusStatIds()}
      />

      {/* Confirmation Modal for Deletion */}
      {showDeleteConfirm && bonusToDelete && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          onConfirm={confirmDeleteBonus}
          onCancel={cancelDeleteBonus}
          title="Delete Master Level Bonus"
          message={`Are you sure you want to delete the "${bonusToDelete.statName}" bonus? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
        />
      )}
    </>
  );
}

export default MasterLevelBonusesGrid;

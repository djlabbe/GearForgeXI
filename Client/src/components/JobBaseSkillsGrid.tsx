import { useState } from "react";
import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";
import { JobConfigurationsService } from "../services";
import ConfirmationModal from "./ConfirmationModal";

import type {
  CellValueChangedEvent,
  ColDef,
  ICellRendererParams,
} from "ag-grid-community";
import type { JobBaseSkill } from "../models/JobConfiguration";
import AddJobBaseSkillModal from "./AddJobBaseSkillModal";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

// Skill rank options for the dropdown
const SKILL_RANK_OPTIONS = [
  { value: "APlus", label: "A+" },
  { value: "AMinus", label: "A-" },
  { value: "BPlus", label: "B+" },
  { value: "B", label: "B" },
  { value: "BMinus", label: "B-" },
  { value: "CPlus", label: "C+" },
  { value: "C", label: "C" },
  { value: "CMinus", label: "C-" },
  { value: "D", label: "D" },
  { value: "E", label: "E" },
  { value: "F", label: "F" },
];

// Convert enum value to display label
const getSkillRankDisplayLabel = (enumValue: string): string => {
  const option = SKILL_RANK_OPTIONS.find(opt => opt.value === enumValue);
  return option ? option.label : enumValue;
};

interface JobBaseSkillsGridProps {
  jobBaseSkills: JobBaseSkill[];
  onJobBaseSkillsChange: (newJobBaseSkills: JobBaseSkill[]) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
  height?: number;
}

export function JobBaseSkillsGrid({
  jobBaseSkills,
  onJobBaseSkillsChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
  height = 400,
}: JobBaseSkillsGridProps) {
  const [isAddBaseSkillModalOpen, setIsAddBaseSkillModalOpen] = useState(false);
  const [showDeleteConfirm, setShowDeleteConfirm] = useState(false);
  const [baseSkillToDelete, setBaseSkillToDelete] = useState<{
    statId: number;
    statName: string;
  } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);

  // Column definitions for Job Base Skills
  const baseSkillsColumnDefs: ColDef<JobBaseSkill>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Stat ID",
      field: "stat.id",
      width: 100,
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
      headerName: "Rank",
      field: "skillRank",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
      cellEditorPopup: false,
      cellEditor: "agSelectCellEditor",
      cellEditorParams: {
        values: SKILL_RANK_OPTIONS.map(option => option.value),
        formatValue: (value: string) => getSkillRankDisplayLabel(value),
      },
      valueFormatter: (params) => {
        return getSkillRankDisplayLabel(params.value);
      },
    },
    {
      headerName: "Actions",
      width: 120,
      sortable: false,
      filter: false,
      editable: false,
      cellRenderer: (params: ICellRendererParams<JobBaseSkill>) => {
        const baseSkill = params.data;
        if (!baseSkill) return null;

        const statName =
          baseSkill.stat?.displayName ||
          baseSkill.stat?.name ||
          `Stat ID ${baseSkill.statId}`;

        return (
          <div className="flex justify-center items-center h-full space-x-2">
            {/* Delete Button - Only show if admin */}
            {isAdmin && (
              <button
                onClick={() =>
                  handleDeleteBaseSkill(baseSkill.statId, statName)
                }
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

  const handleAddBaseSkill = () => {
    setIsAddBaseSkillModalOpen(true);
  };

  const handleJobBaseSkillCreated = (newJobBaseSkill: JobBaseSkill) => {
    const updatedJobBaseSkills = [...jobBaseSkills, newJobBaseSkill];
    onJobBaseSkillsChange(updatedJobBaseSkills);
  };

  const getExistingBaseSkillIds = (): number[] => {
    return jobBaseSkills.map((baseSkill) => baseSkill.statId);
  };

  const handleBaseSkillCellValueChanged = async (
    event: CellValueChangedEvent<JobBaseSkill>
  ) => {
    const updatedSkill = event.data;
    try {
      await JobConfigurationsService.updateJobBaseSkill(
        jobConfigurationId,
        updatedSkill.statId,
        updatedSkill.skillRank
      );
      console.log("Skill updated successfully");

      // Flash the cell green to indicate successful save
      event.api.flashCells({
        rowNodes: [event.node],
        columns: [event.column.getColId()],
      });
    } catch {
      // Revert the change if the update failed
      event.node.setData(event.oldValue);
      alert("Failed to update skill. Please try again.");
    }
  };

  const handleDeleteBaseSkill = (statId: number, statName: string) => {
    setBaseSkillToDelete({ statId, statName });
    setShowDeleteConfirm(true);
  };

  const confirmDeleteBaseSkill = async () => {
    if (!baseSkillToDelete) return;

    setIsDeleting(true);
    try {
      await JobConfigurationsService.deleteJobBaseSkill(
        jobConfigurationId,
        baseSkillToDelete.statId
      );

      // Update the local state by removing the deleted base skill
      const updatedJobBaseSkills = jobBaseSkills.filter(
        (baseSkill) => baseSkill.statId !== baseSkillToDelete.statId
      );
      onJobBaseSkillsChange(updatedJobBaseSkills);

      setShowDeleteConfirm(false);
      setBaseSkillToDelete(null);
      console.log("Base skill deleted successfully");
    } catch (error) {
      console.error("Error deleting base skill:", error);
      alert("Failed to delete base skill. Please try again.");
    } finally {
      setIsDeleting(false);
    }
  };

  const cancelDeleteBaseSkill = () => {
    if (isDeleting) return; // Don't allow canceling while deleting
    setShowDeleteConfirm(false);
    setBaseSkillToDelete(null);
  };

  return (
    <>
      <div className="space-y-2">
        <div className="flex justify-between items-center">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Base Skills ({jobBaseSkills.length})
          </h3>
          {isAdmin && (
            <button
              onClick={handleAddBaseSkill}
              className="px-3 py-1 text-sm bg-blue-600 hover:bg-blue-700 text-white rounded-md transition-colors duration-200 font-medium cursor-pointer"
            >
              Add Base Skill
            </button>
          )}
        </div>
        <div
          className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
          style={{ height, width: "100%" }}
        >
          <AgGridReact<JobBaseSkill>
            theme={isDarkMode ? themeDarkBlue : themeAlpine}
            rowData={jobBaseSkills}
            columnDefs={baseSkillsColumnDefs}
            onCellValueChanged={handleBaseSkillCellValueChanged}
            defaultColDef={{
              resizable: true,
              sortable: true,
              filter: true,
            }}
          />
        </div>
      </div>

      {/* Add Job Base Skill Modal */}
      <AddJobBaseSkillModal
        isOpen={isAddBaseSkillModalOpen}
        onClose={() => setIsAddBaseSkillModalOpen(false)}
        onJobBaseSkillCreated={handleJobBaseSkillCreated}
        jobConfigurationId={jobConfigurationId}
        existingStatIds={getExistingBaseSkillIds()}
      />

      {/* Confirmation Modal for Deletion */}
      {showDeleteConfirm && baseSkillToDelete && (
        <ConfirmationModal
          isOpen={showDeleteConfirm}
          onConfirm={confirmDeleteBaseSkill}
          onCancel={cancelDeleteBaseSkill}
          title="Delete Base Skill"
          message={`Are you sure you want to delete the base skill "${baseSkillToDelete.statName}"? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
          isLoading={isDeleting}
        />
      )}
    </>
  );
}

export default JobBaseSkillsGrid;

import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";

import type { ColDef } from "ag-grid-community";
import type { MasterLevelBonus } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface MasterLevelBonusesGridProps {
  masterLevelBonuses: MasterLevelBonus[];
  onMasterLevelBonusesChange: (newMasterLevelBonuses: MasterLevelBonus[]) => void;
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
  // Column definitions for Master Level Bonuses
  const mlBonusesColumnDefs: ColDef<MasterLevelBonus>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Level",
      field: "level",
      width: 100,
      editable: isAdmin,
      enableCellChangeFlash: true,
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
    },
  ];

  return (
    <div className="space-y-2">
      <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
        Master Level Bonuses ({masterLevelBonuses.length})
      </h3>
      <div
        className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
        style={{ height: 300, width: "100%" }}
      >
        <AgGridReact<MasterLevelBonus>
          theme={isDarkMode ? themeDarkBlue : themeAlpine}
          rowData={masterLevelBonuses}
          columnDefs={mlBonusesColumnDefs}
          defaultColDef={{
            resizable: true,
            sortable: true,
            filter: true,
          }}
        />
      </div>
    </div>
  );
}

export default MasterLevelBonusesGrid;

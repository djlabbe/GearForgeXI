import { AgGridReact } from "ag-grid-react";
import { themeAlpine } from "ag-grid-community";
import { colorSchemeDarkBlue } from "ag-grid-community";

import type { ColDef } from "ag-grid-community";
import type { JobPointBonus } from "../models/JobConfiguration";

const themeDarkBlue = themeAlpine.withPart(colorSchemeDarkBlue);

interface JobPointBonusesGridProps {
  jobPointBonuses: JobPointBonus[];
  onJobPointBonusesChange: (newJobPointBonuses: JobPointBonus[]) => void;
  jobConfigurationId: number;
  isAdmin: boolean;
  isDarkMode: boolean;
}

export function JobPointBonusesGrid({
  jobPointBonuses,
  onJobPointBonusesChange,
  jobConfigurationId,
  isAdmin,
  isDarkMode,
}: JobPointBonusesGridProps) {
  // Column definitions for Job Point Bonuses
  const jpBonusesColumnDefs: ColDef<JobPointBonus>[] = [
    {
      headerName: "ID",
      field: "id",
      width: 80,
      editable: false,
    },
    {
      headerName: "Category",
      field: "category",
      width: 200,
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
        Job Point Bonuses ({jobPointBonuses.length})
      </h3>
      <div
        className="ag-theme-alpine dark:ag-theme-alpine-dark rounded-xl shadow-md border border-gray-200 dark:border-gray-700"
        style={{ height: 300, width: "100%" }}
      >
        <AgGridReact<JobPointBonus>
          theme={isDarkMode ? themeDarkBlue : themeAlpine}
          rowData={jobPointBonuses}
          columnDefs={jpBonusesColumnDefs}
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

export default JobPointBonusesGrid;

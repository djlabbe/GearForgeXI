import { components } from "react-select";

interface VerifiedGearOptionData {
  value: string;
  label: string;
  verified?: boolean;
  rank?: number;
  path?: string;
}

export const VerifiedGearOption = (props: any) => {
  const { data }: { data: VerifiedGearOptionData } = props;
  
  return (
    <components.Option {...props}>
      <div className="flex items-center justify-between w-full">
        <div className="flex items-center space-x-2 flex-1 min-w-0">
          <span className="truncate">{data.label}</span>
          {(data.rank != null || data.path) && (
            <div className="flex items-center space-x-1">
              {data.rank != null && (
                <span className="bg-blue-100 text-blue-800 px-1.5 py-0.5 rounded text-xs font-medium dark:bg-blue-900 dark:text-blue-200">
                  R{data.rank}
                </span>
              )}
              {data.path && (
                <span className="bg-purple-100 text-purple-800 px-1.5 py-0.5 rounded text-xs font-medium dark:bg-purple-900 dark:text-purple-200">
                  {data.path}
                </span>
              )}
            </div>
          )}
        </div>
        {data.verified && (
          <span 
            className="text-green-500 text-sm ml-2 flex-shrink-0" 
            title="Admin Verified"
          >
            ✓
          </span>
        )}
      </div>
    </components.Option>
  );
};

export const VerifiedGearSingleValue = (props: any) => {
  const { data }: { data: VerifiedGearOptionData } = props;
  
  return (
    <components.SingleValue {...props}>
      <div className="flex items-center space-x-2">
        <span className="truncate">{data.label}</span>
        {(data.rank != null || data.path) && (
          <div className="flex items-center space-x-1">
            {data.rank != null && (
              <span className="bg-blue-100 text-blue-800 px-1.5 py-0.5 rounded text-xs font-medium dark:bg-blue-900 dark:text-blue-200">
                R{data.rank}
              </span>
            )}
            {data.path && (
              <span className="bg-purple-100 text-purple-800 px-1.5 py-0.5 rounded text-xs font-medium dark:bg-purple-900 dark:text-purple-200">
                {data.path}
              </span>
            )}
          </div>
        )}
        {data.verified && (
          <span 
            className="text-green-500 text-sm ml-2" 
            title="Admin Verified"
          >
            ✓
          </span>
        )}
      </div>
    </components.SingleValue>
  );
};

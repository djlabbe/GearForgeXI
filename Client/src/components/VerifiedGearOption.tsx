import { components } from "react-select";

interface VerifiedGearOptionData {
  value: string;
  label: string;
  verified?: boolean;
}

export const VerifiedGearOption = (props: any) => {
  const { data }: { data: VerifiedGearOptionData } = props;
  
  return (
    <components.Option {...props}>
      <div className="flex items-center justify-between w-full">
        <span className="flex-1 truncate">{data.label}</span>
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
      <div className="flex items-center">
        <span className="truncate">{data.label}</span>
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

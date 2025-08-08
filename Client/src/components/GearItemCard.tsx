import { memo } from "react";
import type { GearItem } from "../models/GearItem";
import Card from "./Card";

interface GearItemCardProps {
    item: GearItem;
    onEditItem?: (item: GearItem) => void;
    showEditButton?: boolean;
}

const GearItemCard = memo(({ item: currentItem, onEditItem, showEditButton = false }: GearItemCardProps) => {

    const handleEditClick = async () => {
        if (onEditItem) {
            onEditItem(currentItem);
        }
    };

    return (
        <>
            <Card key={currentItem.id}>
                <div className="flex items-baseline justify-between mb-2">
                    <div className="flex items-center space-x-2 flex-1 mr-2">
                        {currentItem.verified && (
                            <span 
                                className="text-green-500 text-sm flex-shrink-0" 
                                title="Admin Verified"
                            >
                                ✓
                            </span>
                        )}
                        <h3 className="font-semibold text-lg text-gray-900 dark:text-gray-100">
                            {currentItem.name}
                        </h3>
                        {(currentItem.rank != null || currentItem.path) && (
                            <div className="flex items-center space-x-1 text-sm">
                                {currentItem.rank != null && (
                                    <span className="bg-blue-100 text-blue-800 px-2 py-0.5 rounded text-xs font-medium dark:bg-blue-900 dark:text-blue-200">
                                        R{currentItem.rank}
                                    </span>
                                )}
                                {currentItem.path && (
                                    <span className="bg-purple-100 text-purple-800 px-2 py-0.5 rounded text-xs font-medium dark:bg-purple-900 dark:text-purple-200">
                                        {currentItem.path}
                                    </span>
                                )}
                            </div>
                        )}
                        {showEditButton && (
                            <button
                                onClick={handleEditClick}
                                className="p-1 text-gray-400 hover:text-blue-600 transition-colors "
                                title="Edit item"
                            >
                                <svg className="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M11 5H6a2 2 0 00-2 2v11a2 2 0 002 2h11a2 2 0 002-2v-5m-1.414-9.414a2 2 0 112.828 2.828L11.828 15H9v-2.828l8.586-8.586z" />
                                </svg>
                            </button>
                        )}
                    </div>
                    <span className="text-sm text-gray-600 dark:text-gray-400 text-right">
                        {currentItem.slots.join(", ")} {currentItem.category && `(${currentItem.category})`}
                    </span>
                </div>
                {currentItem.jobs.length > 0 && (
                    <p className="text-sm text-gray-600 dark:text-gray-400 mb-2">
                        {currentItem.jobs.join(", ")}
                    </p>
                )}
                <ul className="text-sm">
                    {currentItem.stats.map((stat) => (
                        <li key={stat.name} className="text-gray-800 dark:text-gray-200">
                            {stat.displayName || stat.name}:{" "}
                            <span className="font-semibold text-gray-900 dark:text-gray-100">
                                {stat.value}
                            </span>
                        </li>
                    ))}
                </ul>
            </Card>
        </>
    );
});

GearItemCard.displayName = 'GearItemCard';

export default GearItemCard;

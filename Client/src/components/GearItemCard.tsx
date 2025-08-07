import { memo, useState } from "react";
import type { GearItem } from "../models/GearItem";
import Card from "./Card";
import Modal from "./Modal";
import GearItemEditor from "./GearItemEditor";

interface GearItemCardProps {
    item: GearItem;
    onItemUpdate: (updatedItem: GearItem) => void;
    onEditItem?: (item: GearItem) => void;
    showEditButton?: boolean;
}

const GearItemCard = memo(({ item: currentItem, onItemUpdate, onEditItem, showEditButton = false }: GearItemCardProps) => {
    const [isEditingSlots, setIsEditingSlots] = useState(false);

    const handleItemUpdate = (updatedItem: GearItem) => {
        onItemUpdate(updatedItem);
        setIsEditingSlots(false);
    };

    const handleEditClick = async () => {
        if (onEditItem) {
            onEditItem(currentItem);
        } else {
            // Fallback to old slot-only editing
            setIsEditingSlots(true);
        }
    };

    return (
        <>
            <Card key={currentItem.id}>
                <div className="flex items-baseline justify-between mb-2">
                    <div className="flex items-center space-x-2 flex-1 mr-2">
                        {currentItem.verified && (
                            <span
                                className="inline-flex items-center p-1 rounded-full bg-green-100 text-green-700 dark:bg-green-800 dark:text-green-200"
                                title="Verified item"
                            >
                                <svg
                                    className="w-3 h-3 text-green-600 dark:text-green-300"
                                    fill="none"
                                    stroke="currentColor"
                                    viewBox="0 0 24 24"
                                >
                                    <path
                                        strokeLinecap="round"
                                        strokeLinejoin="round"
                                        strokeWidth={2}
                                        d="M5 13l4 4L19 7"
                                    />
                                </svg>
                            </span>
                        )}
                        <h3 className="font-semibold text-lg text-gray-900 dark:text-gray-100">
                            {currentItem.name}
                        </h3>
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

            <Modal isOpen={isEditingSlots} onClose={() => setIsEditingSlots(false)} size="lg">
                <GearItemEditor
                    item={currentItem}
                    onUpdate={handleItemUpdate}
                    onCancel={() => setIsEditingSlots(false)}
                    onClose={() => setIsEditingSlots(false)}
                />
            </Modal>
        </>
    );
});

GearItemCard.displayName = 'GearItemCard';

export default GearItemCard;

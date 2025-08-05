import { memo, useState } from "react";
import type { GearItem } from "../models/GearItem";
import Card from "./Card";
import Modal from "./Modal";
import SlotEditor from "./SlotEditor";

interface GearItemCardProps {
    item: GearItem;
    onItemUpdate?: (updatedItem: GearItem) => void;
    showEditButton?: boolean;
}

const GearItemCard = memo(({ item, onItemUpdate, showEditButton = false }: GearItemCardProps) => {
    const [currentItem, setCurrentItem] = useState<GearItem>(item);
    const [isEditingSlots, setIsEditingSlots] = useState(false);

    const handleItemUpdate = (updatedItem: GearItem) => {
        setCurrentItem(updatedItem);
        onItemUpdate?.(updatedItem);
        setIsEditingSlots(false);
    };

    const handleEditClick = async () => {
        setIsEditingSlots(true);
    };

    return (
        <>
            <Card key={currentItem.id}>
                <div className="flex items-baseline justify-between mb-2">
                    <h3 className="font-semibold text-lg text-gray-900 dark:text-gray-100 mr-2">
                        {currentItem.name}
                    </h3>
                    <div className="flex items-center space-x-2">
                        {showEditButton && (
                            <button
                                onClick={handleEditClick}
                                className="p-1 text-gray-400 hover:text-blue-600 transition-colors cursor-pointer"
                                title="Edit slots"
                            >
                                <svg className="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M11 5H6a2 2 0 00-2 2v11a2 2 0 002 2h11a2 2 0 002-2v-5m-1.414-9.414a2 2 0 112.828 2.828L11.828 15H9v-2.828l8.586-8.586z" />
                                </svg>
                            </button>
                        )}
                        <span className="text-sm text-gray-600 dark:text-gray-400 text-right">
                            {currentItem.slots.join(", ")} {currentItem.category && `(${currentItem.category})`}
                        </span>
                    </div>
                </div>
                {currentItem.jobs.length > 0 && (
                    <p className="text-sm text-gray-600 dark:text-gray-400 mb-2">
                        {currentItem.jobs.join(", ")}
                    </p>
                )}
                <ul className="text-sm">
                    {currentItem.stats.map((stat) => (
                        <li key={stat.name} className="text-gray-800 dark:text-gray-200">
                            {stat.name}:{" "}
                            <span className="font-semibold text-gray-900 dark:text-gray-100">
                                {stat.value}
                            </span>
                        </li>
                    ))}
                </ul>
            </Card>

            <Modal isOpen={isEditingSlots} onClose={() => setIsEditingSlots(false)} size="lg">
                <SlotEditor
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

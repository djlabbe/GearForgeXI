import { memo } from "react";
import type { GearItem } from "../models/GearItem";
import Card from "./Card";

interface GearItemCardProps {
    item: GearItem;
}

const GearItemCard = memo(({ item }: GearItemCardProps) => {
    return (
        <Card key={item.id}>
            <div className="flex items-baseline justify-between mb-2">
                <h3 className="font-semibold text-lg text-gray-900 dark:text-gray-100 mr-2">
                    {item.name}
                </h3>
                <span className="text-sm text-gray-600 dark:text-gray-400 text-right">
                    {item.slots.join(", ")} {item.category && `(${item.category})`}
                </span>
            </div>
            {item.jobs.length > 0 && (
                <p className="text-sm text-gray-600 dark:text-gray-400 mb-2">
                    {item.jobs.join(", ")}
                </p>
            )}
            <ul className="text-sm">
                {item.stats.map((stat) => (
                    <li key={stat.name} className="text-gray-800 dark:text-gray-200">
                        {stat.name}:{" "}
                        <span className="font-semibold text-gray-900 dark:text-gray-100">
                            {stat.value}
                        </span>
                    </li>
                ))}
            </ul>
        </Card>
    );
});

GearItemCard.displayName = 'GearItemCard';

export default GearItemCard;

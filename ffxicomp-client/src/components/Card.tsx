import React from 'react';

interface CardProps extends React.HTMLAttributes<HTMLDivElement> {
    children: React.ReactNode;
    className?: string;
}

const Card: React.FC<CardProps> = ({ children, className = '', ...props }) => {
    return (
        <div
            className={`w-full rounded-lg shadow-md p-6 bg-white dark:bg-gray-800 text-gray-900 dark:text-gray-100 ${className}`}
            {...props}
        >
            {children}
        </div>
    );
};

export default Card;
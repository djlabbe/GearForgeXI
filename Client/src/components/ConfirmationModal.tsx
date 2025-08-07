import { useEffect } from "react";

interface ConfirmationModalProps {
  isOpen: boolean;
  title: string;
  message: string;
  confirmText?: string;
  cancelText?: string;
  confirmButtonClass?: string;
  onConfirm: () => void;
  onCancel: () => void;
}

export default function ConfirmationModal({
  isOpen,
  title,
  message,
  confirmText = "Confirm",
  cancelText = "Cancel",
  confirmButtonClass = "bg-red-600 hover:bg-red-700 focus:ring-red-500",
  onConfirm,
  onCancel,
}: ConfirmationModalProps) {
  // Handle escape key
  useEffect(() => {
    const handleEscape = (event: KeyboardEvent) => {
      if (event.key === "Escape") {
        onCancel();
      }
    };

    if (isOpen) {
      // Calculate scrollbar width before hiding overflow
      const scrollbarWidth = window.innerWidth - document.documentElement.clientWidth;
      
      document.addEventListener("keydown", handleEscape);
      document.body.style.overflow = "hidden";
      document.body.style.paddingRight = `${scrollbarWidth}px`;
    }

    return () => {
      document.removeEventListener("keydown", handleEscape);
      document.body.style.overflow = "unset";
      document.body.style.paddingRight = "0px";
    };
  }, [isOpen, onCancel]);

  if (!isOpen) return null;

  return (
    <div className="fixed inset-0 z-50 overflow-y-auto">
      {/* Background overlay */}
      <div
        className="fixed inset-0 transition-opacity"
        style={{ backgroundColor: 'rgba(0, 0, 0, 0.5)' }}
        onClick={onCancel}
      />
      
      <div className="flex items-center justify-center min-h-screen px-4 pt-20 pb-20 text-center sm:block sm:p-0">
        {/* Modal panel */}
        <div className="relative z-10 inline-block w-full max-w-md p-0 mt-20 mb-8 overflow-hidden text-left align-middle transition-all transform bg-white shadow-xl rounded-lg dark:bg-gray-800">
          <button
            onClick={onCancel}
            className="absolute top-4 right-4 p-1 rounded-full text-gray-400 hover:text-gray-600 hover:bg-gray-100 dark:hover:text-gray-300 dark:hover:bg-gray-700 transition-colors cursor-pointer"
          >
            <svg
              className="w-5 h-5"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth={2}
                d="M6 18L18 6M6 6l12 12"
              />
            </svg>
          </button>

          {/* Modal content */}
          <div className="p-6">
            {/* Header */}
            <div className="mb-4">
              <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
                {title}
              </h3>
            </div>

            {/* Message */}
            <div className="mb-6">
              <p className="text-gray-700 dark:text-gray-300">
                {message}
              </p>
            </div>

            {/* Buttons */}
            <div className="flex space-x-3 justify-end">
              <button
                type="button"
                onClick={onCancel}
                className="px-4 py-2 text-sm font-medium text-gray-700 dark:text-gray-300 bg-gray-100 dark:bg-gray-700 hover:bg-gray-200 dark:hover:bg-gray-600 rounded-md transition-colors duration-200 focus:outline-none focus:ring-2 focus:ring-gray-500"
              >
                {cancelText}
              </button>
              <button
                type="button"
                onClick={onConfirm}
                className={`px-4 py-2 text-sm font-medium text-white rounded-md transition-colors duration-200 focus:outline-none focus:ring-2 ${confirmButtonClass}`}
              >
                {confirmText}
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

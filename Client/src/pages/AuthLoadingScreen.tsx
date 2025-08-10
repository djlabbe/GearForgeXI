import LoadingSpinner from "../components/LoadingSpinner";

interface AuthLoadingScreenProps {
  message?: string;
}

export const AuthLoadingScreen: React.FC<AuthLoadingScreenProps> = ({ 
  message = "Authenticating..." 
}) => {
  return (
    <div className="min-h-screen bg-white dark:bg-gray-900 flex items-center justify-center">
      <div className="text-center">
        <LoadingSpinner message={message} size="lg" />
      </div>
    </div>
  );
};
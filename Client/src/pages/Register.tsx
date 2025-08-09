import { useState, useEffect } from "react";
import { useNavigate, Link } from "react-router-dom";
import Card from "../components/Card";
import { register as authRegister } from "../utils/authService";
import { useAuth } from "../contexts/AuthContext";

export function Register() {
  const [formData, setFormData] = useState({
    email: "",
    password: "",
    confirmPassword: "",
  });
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const navigate = useNavigate();
  const { login, isAuthenticated } = useAuth();

  // Redirect if already authenticated
  useEffect(() => {
    if (isAuthenticated) {
      navigate("/");
    }
  }, [isAuthenticated, navigate]);

  const handleInputChange = (field: "email" | "password" | "confirmPassword", value: string) => {
    setFormData((prev) => ({
      ...prev,
      [field]: value,
    }));
    // Clear error when user starts typing
    if (error) {
      setError(null);
    }
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setIsSubmitting(true);
    setError(null);

    try {
      await authRegister(formData.email, formData.password, formData.confirmPassword);
      // Update the global auth state (tokens are now handled by authService)
      login();
      // Redirect to the main page after successful registration
      navigate("/");
    } catch (err) {
      console.error("Registration error:", err);
      setError(
        err instanceof Error ? err.message : "Registration failed. Please try again."
      );
    } finally {
      setIsSubmitting(false);
    }
  };

  const isFormValid = 
    formData.email.trim() && 
    formData.password.trim() && 
    formData.confirmPassword.trim() &&
    formData.password === formData.confirmPassword;

  const passwordsMatch = !formData.confirmPassword || formData.password === formData.confirmPassword;

  return (
    <div className="min-h-screen flex justify-center py-12 px-4 sm:px-6 lg:px-8 bg-gray-50 dark:bg-gray-900">
      <div className="max-w-md w-full space-y-8">
        <div>
          <div className="mx-auto h-12 w-12 flex items-center justify-center rounded-full bg-green-100 dark:bg-green-900">
            <svg
              className="h-6 w-6 text-green-600 dark:text-green-400"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth={2}
                d="M12 6v6m0 0v6m0-6h6m-6 0H6"
              />
            </svg>
          </div>
          <h2 className="mt-6 text-center text-3xl font-bold text-gray-900 dark:text-white">
            Create your account
          </h2>
          <p className="mt-2 text-center text-sm text-gray-600 dark:text-gray-400">
            Join the FFXI gear optimization community
          </p>
        </div>

        <Card className="max-w-md">
          {error && (
            <div className="mb-4 p-3 bg-red-100 border border-red-400 text-red-700 rounded dark:bg-red-900/20 dark:border-red-800 dark:text-red-400">
              {error}
            </div>
          )}

          <form
            onSubmit={handleSubmit}
            className="space-y-6"
            autoComplete="off"
          >
            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Email Address *
              </label>
              <input
                type="email"
                id="email"
                name="register-email"
                value={formData.email}
                onChange={(e) => handleInputChange("email", e.target.value)}
                required
                disabled={isSubmitting}
                autoComplete="username"
                data-lpignore="true"
                data-form-type="register"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-green-500 focus:border-green-500 placeholder-gray-400 dark:placeholder-gray-500 disabled:bg-gray-50 disabled:text-gray-700 dark:disabled:bg-gray-800 dark:disabled:text-gray-200 disabled:border-gray-200 dark:disabled:border-gray-700 disabled:cursor-not-allowed"
                placeholder="Enter your email"
              />
            </div>

            <div>
              <label
                htmlFor="password"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Password *
              </label>
              <input
                type="password"
                id="password"
                name="register-password"
                value={formData.password}
                onChange={(e) => handleInputChange("password", e.target.value)}
                required
                disabled={isSubmitting}
                autoComplete="new-password"
                data-lpignore="true"
                data-form-type="register"
                className="w-full p-2 border border-gray-300 dark:border-gray-600 rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 focus:ring-green-500 focus:border-green-500 placeholder-gray-400 dark:placeholder-gray-500 disabled:bg-gray-50 disabled:text-gray-700 dark:disabled:bg-gray-800 dark:disabled:text-gray-200 disabled:border-gray-200 dark:disabled:border-gray-700 disabled:cursor-not-allowed"
                placeholder="Create a password"
              />
            </div>

            <div>
              <label
                htmlFor="confirmPassword"
                className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-2"
              >
                Confirm Password *
              </label>
              <input
                type="password"
                id="confirmPassword"
                name="register-confirm-password"
                value={formData.confirmPassword}
                onChange={(e) => handleInputChange("confirmPassword", e.target.value)}
                required
                disabled={isSubmitting}
                autoComplete="new-password"
                data-lpignore="true"
                data-form-type="register"
                className={`w-full p-2 border rounded-md bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 focus:ring-2 placeholder-gray-400 dark:placeholder-gray-500 disabled:bg-gray-50 disabled:text-gray-700 dark:disabled:bg-gray-800 dark:disabled:text-gray-200 disabled:border-gray-200 dark:disabled:border-gray-700 disabled:cursor-not-allowed ${
                  passwordsMatch
                    ? "border-gray-300 dark:border-gray-600 focus:ring-green-500 focus:border-green-500"
                    : "border-red-300 dark:border-red-600 focus:ring-red-500 focus:border-red-500"
                }`}
                placeholder="Confirm your password"
              />
              {formData.confirmPassword && !passwordsMatch && (
                <p className="mt-1 text-sm text-red-600 dark:text-red-400">
                  Passwords do not match
                </p>
              )}
            </div>

            <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
              <div className="text-sm text-gray-600 dark:text-gray-400">
                {isFormValid
                  ? "Ready to create account"
                  : formData.confirmPassword && !passwordsMatch
                  ? "Passwords must match"
                  : "All fields are required"}
              </div>
              <button
                type="submit"
                disabled={!isFormValid || isSubmitting}
                className="px-6 py-2 text-sm font-medium text-white bg-green-600 border border-transparent rounded-md hover:bg-green-700 focus:outline-none focus:ring-2 focus:ring-green-500 disabled:opacity-50 disabled:cursor-not-allowed transition-colors duration-200"
              >
                {isSubmitting ? (
                  <div className="flex items-center space-x-2">
                    <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                    <span>Creating account...</span>
                  </div>
                ) : (
                  "Create Account"
                )}
              </button>
            </div>
          </form>

          <div className="mt-6 text-center">
            <p className="text-sm text-gray-600 dark:text-gray-400">
              Already have an account?{" "}
              <Link
                to="/login"
                className="font-medium text-green-600 hover:text-green-500 dark:text-green-400 dark:hover:text-green-300"
              >
                Sign in here
              </Link>
            </p>
          </div>
        </Card>
      </div>
    </div>
  );
}

export default Register;

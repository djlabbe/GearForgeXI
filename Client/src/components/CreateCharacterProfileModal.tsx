import { useState } from 'react';
import Modal from './Modal';
import type { CreateCharacterProfileDto } from '../models/CharacterProfile';
import { SERVERS, RACES } from '../models/CharacterProfile';

interface CreateCharacterProfileModalProps {
  onClose: () => void;
  onSubmit: (profile: CreateCharacterProfileDto) => Promise<void>;
}

export function CreateCharacterProfileModal({ onClose, onSubmit }: CreateCharacterProfileModalProps) {
  const [formData, setFormData] = useState({
    characterName: '',
    server: '',
    race: '',
  });
  const [errors, setErrors] = useState<Record<string, string>>({});
  const [isSubmitting, setIsSubmitting] = useState(false);

  const validateForm = () => {
    const newErrors: Record<string, string> = {};

    if (!formData.characterName.trim()) {
      newErrors.characterName = 'Character name is required';
    } else if (formData.characterName.length > 15) {
      newErrors.characterName = 'Character name must be 15 characters or less';
    }

    if (!formData.server) {
      newErrors.server = 'Server is required';
    }

    if (!formData.race) {
      newErrors.race = 'Race is required';
    }

    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    
    if (!validateForm()) {
      return;
    }

    setIsSubmitting(true);
    try {
      const profileData: CreateCharacterProfileDto = {
        characterName: formData.characterName.trim(),
        server: parseInt(formData.server),
        race: parseInt(formData.race),
      };

      await onSubmit(profileData);
    } catch (error) {
      if (error instanceof Error) {
        setErrors({ submit: error.message });
      } else {
        setErrors({ submit: 'Failed to create character profile' });
      }
    } finally {
      setIsSubmitting(false);
    }
  };

  const handleInputChange = (field: string, value: string) => {
    setFormData(prev => ({ ...prev, [field]: value }));
    // Clear error when user starts typing
    if (errors[field]) {
      setErrors(prev => ({ ...prev, [field]: '' }));
    }
  };

  return (
    <Modal isOpen={true} onClose={onClose}>
      <div className="p-4 space-y-6">
        <div>
          <h3 className="text-lg font-semibold text-gray-900 dark:text-gray-100 mb-2">
            Create Character Profile
          </h3>
          <p className="text-sm text-gray-600 dark:text-gray-400">
            Create a new character profile with name, server, and race:
          </p>
        </div>
        
        <form onSubmit={handleSubmit} className="space-y-4">
          {errors.submit && (
            <div className="p-3 bg-red-100 border border-red-400 text-red-700 rounded dark:bg-red-900 dark:border-red-600 dark:text-red-200">
              {errors.submit}
            </div>
          )}        <div>
          <label htmlFor="characterName" className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-1">
            Character Name *
          </label>
          <input
            type="text"
            id="characterName"
            value={formData.characterName}
            onChange={(e) => handleInputChange('characterName', e.target.value)}
            className={`w-full px-3 py-2 border rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:text-gray-100 ${
              errors.characterName ? 'border-red-500' : 'border-gray-300 dark:border-gray-600'
            }`}
            placeholder="Enter character name"
            maxLength={15}
          />
          {errors.characterName && (
            <p className="text-red-500 text-sm mt-1">{errors.characterName}</p>
          )}
        </div>

        <div>
          <label htmlFor="server" className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-1">
            Server *
          </label>
          <select
            id="server"
            value={formData.server}
            onChange={(e) => handleInputChange('server', e.target.value)}
            className={`w-full px-3 py-2 border rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:text-gray-100 ${
              errors.server ? 'border-red-500' : 'border-gray-300 dark:border-gray-600'
            }`}
          >
            <option value="">Select a server</option>
            {SERVERS.map((server) => (
              <option key={server.id} value={server.id}>
                {server.name}
              </option>
            ))}
          </select>
          {errors.server && (
            <p className="text-red-500 text-sm mt-1">{errors.server}</p>
          )}
        </div>

        <div>
          <label htmlFor="race" className="block text-sm font-medium text-gray-700 dark:text-gray-300 mb-1">
            Race *
          </label>
          <select
            id="race"
            value={formData.race}
            onChange={(e) => handleInputChange('race', e.target.value)}
            className={`w-full px-3 py-2 border rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:text-gray-100 ${
              errors.race ? 'border-red-500' : 'border-gray-300 dark:border-gray-600'
            }`}
          >
            <option value="">Select a race</option>
            {RACES.map((race) => (
              <option key={race.id} value={race.id}>
                {race.displayName}
              </option>
            ))}
          </select>
          {errors.race && (
            <p className="text-red-500 text-sm mt-1">{errors.race}</p>
          )}
        </div>

          <div className="flex justify-between items-center pt-4 border-t border-gray-200 dark:border-gray-700">
            <div className="text-sm text-gray-600 dark:text-gray-400">
              {formData.characterName && formData.server && formData.race ? 'Ready to create profile' : 'Name, server, and race are required'}
            </div>
            
            <div className="flex space-x-2">
              <button
                type="button"
                onClick={onClose}
                disabled={isSubmitting}
                className="px-4 py-2 text-sm font-medium text-gray-700 bg-gray-100 border border-gray-300 rounded-md hover:bg-gray-200 focus:outline-none focus:ring-2 focus:ring-gray-500 disabled:opacity-50 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-600 dark:hover:bg-gray-600 cursor-pointer disabled:cursor-not-allowed"
              >
                Cancel
              </button>
              <button
                type="submit"
                disabled={isSubmitting}
                className="px-4 py-2 text-sm font-medium text-white bg-blue-600 border border-transparent rounded-md hover:bg-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-500 disabled:opacity-50 cursor-pointer disabled:cursor-not-allowed"
              >
                {isSubmitting ? (
                  <div className="flex items-center space-x-2">
                    <div className="animate-spin rounded-full h-4 w-4 border-b-2 border-white"></div>
                    <span>Creating...</span>
                  </div>
                ) : (
                  'Create Profile'
                )}
              </button>
            </div>
          </div>
        </form>
      </div>
    </Modal>
  );
}
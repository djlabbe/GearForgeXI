import { useState, useEffect } from 'react';
import { useAuth } from '../contexts/AuthContext';
import ApiService from '../utils/apiService';
import type { CharacterProfile, CreateCharacterProfileDto, UpdateCharacterProfileDto } from '../models/CharacterProfile';
import ConfirmationModal from '../components/ConfirmationModal';
import { LoadingSpinner } from '../components/LoadingSpinner';
import { CharacterProfileCard } from '../components/CharacterProfileCard';
import { CreateCharacterProfileModal } from '../components/CreateCharacterProfileModal';
import { EditCharacterProfileModal } from '../components/EditCharacterProfileModal';
import { ManageJobsModal } from '../components/ManageJobsModal';

export function CharacterProfiles() {
  const { isAuthenticated } = useAuth();
  const [profiles, setProfiles] = useState<CharacterProfile[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [showCreateModal, setShowCreateModal] = useState(false);
  const [showEditModal, setShowEditModal] = useState(false);
  const [showJobsModal, setShowJobsModal] = useState(false);
  const [showDeleteModal, setShowDeleteModal] = useState(false);
  const [selectedProfile, setSelectedProfile] = useState<CharacterProfile | null>(null);

  useEffect(() => {
    if (isAuthenticated) {
      loadProfiles();
    }
  }, [isAuthenticated]);

  const loadProfiles = async () => {
    try {
      setLoading(true);
      setError(null);
      const data = await ApiService.getCharacterProfiles();
      setProfiles(data);
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to load character profiles');
    } finally {
      setLoading(false);
    }
  };

  const handleCreateProfile = async (profileData: CreateCharacterProfileDto) => {
    try {
      await ApiService.createCharacterProfile(profileData);
      setShowCreateModal(false);
      await loadProfiles();
    } catch (err) {
      throw err; // Let the modal handle the error
    }
  };

  const handleEditProfile = async (profileData: UpdateCharacterProfileDto) => {
    if (!selectedProfile) return;
    
    try {
      await ApiService.updateCharacterProfile(selectedProfile.id, profileData);
      setShowEditModal(false);
      setSelectedProfile(null);
      await loadProfiles();
    } catch (err) {
      throw err; // Let the modal handle the error
    }
  };

  const handleDeleteProfile = async () => {
    if (!selectedProfile) return;
    
    try {
      await ApiService.deleteCharacterProfile(selectedProfile.id);
      setShowDeleteModal(false);
      setSelectedProfile(null);
      await loadProfiles();
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to delete character profile');
    }
  };

  const openEditModal = (profile: CharacterProfile) => {
    setSelectedProfile(profile);
    setShowEditModal(true);
  };

  const openJobsModal = (profile: CharacterProfile) => {
    setSelectedProfile(profile);
    setShowJobsModal(true);
  };

  const openDeleteModal = (profile: CharacterProfile) => {
    setSelectedProfile(profile);
    setShowDeleteModal(true);
  };

  const closeModals = () => {
    setShowCreateModal(false);
    setShowEditModal(false);
    setShowJobsModal(false);
    setShowDeleteModal(false);
    setSelectedProfile(null);
  };

  if (!isAuthenticated) {
    return (
      <div className="text-center py-8">
        <h2 className="text-2xl font-semibold text-gray-700 dark:text-gray-300 mb-4">
          Please log in to manage your character profiles
        </h2>
        <p className="text-gray-600 dark:text-gray-400">
          You need to be logged in to create and manage your FFXI character profiles.
        </p>
      </div>
    );
  }

  if (loading) {
    return (
      <div className="flex justify-center items-center py-8">
        <LoadingSpinner />
      </div>
    );
  }

  return (
    <div className="max-w-6xl mx-auto">
      <div className="flex justify-between items-center mb-6">
        <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
          My Characters
        </h1>
        <button
          onClick={() => setShowCreateModal(true)}
          className="bg-blue-600 hover:bg-blue-700 text-white px-4 py-2 rounded-md transition-colors"
        >
          Create New Profile
        </button>
      </div>

      {error && (
        <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded mb-4 dark:bg-red-900 dark:border-red-600 dark:text-red-200">
          {error}
        </div>
      )}

      {profiles.length === 0 ? (
        <div className="text-center py-8">
          <h2 className="text-xl font-semibold text-gray-700 dark:text-gray-300 mb-4">
            No character profiles found
          </h2>
          <p className="text-gray-600 dark:text-gray-400 mb-6">
            Create your first character profile to get started!
          </p>
          <button
            onClick={() => setShowCreateModal(true)}
            className="bg-blue-600 hover:bg-blue-700 text-white px-6 py-3 rounded-md transition-colors"
          >
            Create Your First Profile
          </button>
        </div>
      ) : (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
          {profiles.map((profile) => (
            <CharacterProfileCard
              key={profile.id}
              profile={profile}
              onEdit={() => openEditModal(profile)}
              onManageJobs={() => openJobsModal(profile)}
              onDelete={() => openDeleteModal(profile)}
            />
          ))}
        </div>
      )}

      {/* Modals */}
      {showCreateModal && (
        <CreateCharacterProfileModal
          onClose={closeModals}
          onSubmit={handleCreateProfile}
        />
      )}

      {showEditModal && selectedProfile && (
        <EditCharacterProfileModal
          profile={selectedProfile}
          onClose={closeModals}
          onSubmit={handleEditProfile}
        />
      )}

      {showJobsModal && selectedProfile && (
        <ManageJobsModal
          profile={selectedProfile}
          onClose={closeModals}
          onUpdate={loadProfiles}
        />
      )}

      {showDeleteModal && selectedProfile && (
        <ConfirmationModal
          isOpen={showDeleteModal}
          onCancel={closeModals}
          onConfirm={handleDeleteProfile}
          title="Delete Character Profile"
          message={`Are you sure you want to delete the character profile "${selectedProfile.characterName}"? This action cannot be undone.`}
          confirmText="Delete"
          cancelText="Cancel"
        />
      )}
    </div>
  );
}

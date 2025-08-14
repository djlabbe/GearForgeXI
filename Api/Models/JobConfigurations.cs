namespace GearForgeXI.Models;

/// <summary>
/// Static configuration for all FFXI jobs including traits, job point bonuses, and master level bonuses.
/// Job IDs must match the database Job table IDs.
/// </summary>
public static class JobConfigurations
{
    public static readonly Dictionary<int, JobStaticData> Data = new()
    {


    };

    /// <summary>
    /// Gets the static job configuration for a given job ID
    /// </summary>
    public static JobStaticData? GetJobConfiguration(int jobId)
    {
        return Data.TryGetValue(jobId, out var config) ? config : null;
    }

    /// <summary>
    /// Checks if a job ID has configuration data
    /// </summary>
    public static bool HasConfiguration(int jobId)
    {
        return Data.ContainsKey(jobId);
    }

    /// <summary>
    /// Gets all configured job IDs
    /// </summary>
    public static IEnumerable<int> GetConfiguredJobIds()
    {
        return Data.Keys;
    }
}

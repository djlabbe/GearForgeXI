namespace GearForgeXI.Models;

/// <summary>
/// Database-driven job configuration containing all job-specific data
/// </summary>
public class JobConfiguration
{
    public int Id { get; set; }

    /// <summary>
    /// The job this configuration applies to
    /// </summary>
    public int JobId { get; set; }
    public Job Job { get; set; } = null!;

    /// <summary>
    /// Base stats at level 99 for this job
    /// </summary>
    public List<JobBaseStat> JobBaseStats { get; set; } = new();

    /// <summary>
    /// Job traits that are learned at specific levels
    /// </summary>
    public List<JobTrait> JobTraits { get; set; } = new();

    /// <summary>
    /// Stat bonuses gained from job point categories when mastered
    /// </summary>
    public List<JobPointBonus> JobPointBonuses { get; set; } = new();

    /// <summary>
    /// Stat bonuses gained from master levels
    /// </summary>
    public List<MasterLevelBonus> MasterLevelBonuses { get; set; } = new();
}

namespace GearForgeXI.Models;

/// <summary>
/// Base stat value for a job at level 99, following the same pattern as other stat modifiers
/// </summary>
public class JobBaseStat
{
    public int Id { get; set; }

    /// <summary>
    /// The job configuration this base stat belongs to
    /// </summary>
    public int JobConfigurationId { get; set; }
    public JobConfiguration JobConfiguration { get; set; } = null!;

    /// <summary>
    /// The stat being defined
    /// </summary>
    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    /// <summary>
    /// The BaseStatRank (letter grade) of this stat at level 99
    /// </summary>
    public BaseStatRank BaseStatRank { get; set; }

    public int MaxValue { get; set; }
}

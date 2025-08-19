namespace GearForgeXI.Models;

/// <summary>
/// Stat bonus gained from job gifts
/// </summary>
public class JobGift
{
    public int Id { get; set; }

    /// <summary>
    /// The job configuration this gift belongs to
    /// </summary>
    public int JobConfigurationId { get; set; }
    public JobConfiguration JobConfiguration { get; set; } = null!;

    /// <summary>
    /// The stat being boosted
    /// </summary>
    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    /// <summary>
    /// The value of the job gift bonus
    /// </summary>
    public int Value { get; set; }
}

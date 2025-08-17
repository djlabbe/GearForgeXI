namespace GearForgeXI.Models;

/// <summary>
/// Stat bonus gained from master levels
/// </summary>
public class MasterLevelBonus
{
    public int Id { get; set; }

    /// <summary>
    /// The job configuration this bonus belongs to
    /// </summary>
    public int JobConfigurationId { get; set; }
    public JobConfiguration JobConfiguration { get; set; } = null!;

    /// <summary>
    /// The stat being boosted
    /// </summary>
    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    /// <summary>
    /// The value of the master level bonus
    /// </summary>
    public int Value { get; set; }
}

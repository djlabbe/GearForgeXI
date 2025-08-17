namespace GearForgeXI.Models;

/// <summary>
/// Stat bonus gained from job point categories when mastered
/// </summary>
public class JobPointBonus
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
    /// The value of the job point bonus
    /// </summary>
    public int Value { get; set; }
}

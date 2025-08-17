namespace GearForgeXI.Models;

/// <summary>
/// A job trait that is learned at a specific level
/// </summary>
public class JobTrait
{
    public int Id { get; set; }

    /// <summary>
    /// The job configuration this trait belongs to
    /// </summary>
    public int JobConfigurationId { get; set; }
    public JobConfiguration JobConfiguration { get; set; } = null!;

    /// <summary>
    /// Name of the trait (e.g., "Double Attack V", "Defense Bonus III")
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Job level required to learn this trait
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The stat this trait modifies
    /// </summary>
    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    /// <summary>
    /// The value this trait provides to the stat
    /// </summary>
    public int Value { get; set; }
}

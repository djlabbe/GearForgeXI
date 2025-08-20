namespace GearForgeXI.Models;

/// <summary>
/// Base skill value for a job at level 99, following the same pattern as other stat modifiers
/// </summary>
public class JobBaseSkill
{
    public int Id { get; set; }

    /// <summary>
    /// The job configuration this base skill belongs to
    /// </summary>
    public int JobConfigurationId { get; set; }
    public JobConfiguration JobConfiguration { get; set; } = null!;

    /// <summary>
    /// The stat being defined (skill stats)
    /// </summary>
    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    /// <summary>
    /// The base value of this skill at level 99
    /// </summary>
    public int Value { get; set; }
}

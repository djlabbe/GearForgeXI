namespace GearForgeXI.Models;

/// <summary>
/// Base skill ranking for a job, which combined with character level determines the actual skill value
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
    /// The skill ranking for this job/skill combination (A+, A-, B+, etc.)
    /// This will be combined with the character's job level to look up the actual skill value
    /// </summary>
    public SkillRank SkillRank { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models;

/// <summary>
/// Maps skill rankings (A+, A-, B+, B, B-, C+, C, C-, D, E, F) to numeric skill values for each level.
/// These mappings are constant and not tied to specific jobs.
/// </summary>
public class BaseStatRankMapping
{
    public int Id { get; set; }

    /// <summary>
    /// The base stat ranking (A, B, C, D, E, F, G)
    /// </summary>
    [Required]
    public BaseStatRank BaseStatRank { get; set; }

    /// <summary>
    /// The character level (1-99)
    /// </summary>
    [Range(1, 99)]
    public int Level { get; set; }

    /// <summary>
    /// The numeric base stat value for this rank at this level
    /// </summary>
    public int BaseStatValue { get; set; }
}

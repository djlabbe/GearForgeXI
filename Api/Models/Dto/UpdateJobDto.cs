using System.ComponentModel.DataAnnotations;

namespace GearForgeXI.Models.Dto;

public class UpdateJobDto
{
    [Required]
    [StringLength(10, MinimumLength = 2)]
    public string Abbreviation { get; set; } = null!;  // e.g., "WAR"

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string FullName { get; set; } = null!;      // e.g., "Warrior"

    public bool CanDualWield { get; set; } = false;    // Can this job dual wield?
}

using System.ComponentModel.DataAnnotations;
namespace GearForgeXI.Models;

public class Job
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Abbreviation { get; set; } = null!;  // e.g., "WAR"

    public string FullName { get; set; } = null!;      // e.g., "Warrior"

    public bool CanDualWield { get; set; } = false; // Can this job dual wield?

    // Navigation
    public ICollection<GearItemJob> GearItemJobs { get; set; } = new List<GearItemJob>();
}
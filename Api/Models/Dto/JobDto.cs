namespace FFXIComp.Api.Models.Dto;

public class JobDto
{
    public int Id { get; set; }
    public string Abbreviation { get; set; } = null!;  // e.g., "WAR"
    public string FullName { get; set; } = null!;      // e.g., "Warrior"
}
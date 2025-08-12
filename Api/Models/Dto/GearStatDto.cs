namespace GearForgeXI.Models.Dto;

public class GearStatDto
{
    public string Name { get; set; } = null!;
    public string? DisplayName { get; set; }        // Optional: full name like "Strength"
    public string? Category { get; set; }           // e.g. "Base", "Combat", "Magic", etc.
    public string? Description { get; set; }        // Optional tooltip text
    public int? Value { get; set; }
}
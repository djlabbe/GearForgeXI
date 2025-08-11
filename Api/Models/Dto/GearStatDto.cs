namespace GearForgeXI.Models.Dto;

public class GearStatDto
{
    public string Name { get; set; } = null!;
    public string? DisplayName { get; set; }        // Optional: full name like "Strength"
    public string? AlternateName1 { get; set; }     // First alternative name/abbreviation
    public string? AlternateName2 { get; set; }     // Second alternative name/abbreviation
    public string? Category { get; set; }           // e.g. "Base", "Combat", "Magic", etc.
    public string? Description { get; set; }        // Optional tooltip text
    public int Value { get; set; }
}
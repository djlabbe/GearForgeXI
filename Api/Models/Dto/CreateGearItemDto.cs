namespace GearForgeXI.Models.Dto;

public class CreateGearItemDto
{
    public string Name { get; set; } = null!;
    public string? CategoryName { get; set; }
    public int? Rank { get; set; }
    public string? Path { get; set; }
    public bool? Verified { get; set; } = false; // Admin verification flag
    public List<CreateGearStatDto> Stats { get; set; } = [];
    public List<string> Jobs { get; set; } = [];         // e.g., ["WAR", "NIN"]
    public List<string> Slots { get; set; } = [];        // e.g., ["Main", "Sub"]
}

public class CreateGearStatDto
{
    public string StatName { get; set; } = null!;
    public int Value { get; set; }
}

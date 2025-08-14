namespace GearForgeXI.Models.Dto;

public class CharacterStatsDto
{
    /// <summary>
    /// Dynamic collection of all character stats by name
    /// </summary>
    public Dictionary<string, int> Stats { get; set; } = new();

    /// <summary>
    /// Active job traits
    /// </summary>
    public List<string> ActiveTraits { get; set; } = new();

    /// <summary>
    /// Detailed breakdown showing how each stat was calculated
    /// Key: Stat name, Value: List of modifiers that contributed to that stat
    /// </summary>
    public Dictionary<string, List<StatModifierDto>> StatBreakdown { get; set; } = new();
}

public class StatModifierDto
{
    public int Value { get; set; }
    public string Source { get; set; } = null!;
}

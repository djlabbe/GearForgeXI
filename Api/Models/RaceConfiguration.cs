namespace GearForgeXI.Models;

/// <summary>
/// Configuration for character races with base stat modifiers
/// </summary>
public class RaceConfiguration
{
    public int Id { get; set; }

    /// <summary>
    /// The race name (e.g., "Galka", "Elvaan", "Hume", "Mithra", "Tarutaru")
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The race abbreviation (e.g., "GAL", "ELV", "HUM", "MIT", "TAR")
    /// </summary>
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    /// Base stat modifiers for this race
    /// </summary>
    public List<RaceBaseStat> RaceBaseStats { get; set; } = new();
}

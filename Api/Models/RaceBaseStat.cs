namespace GearForgeXI.Models;

/// <summary>
/// Base stat modifier for a race, following the same pattern as other stat modifiers
/// </summary>
public class RaceBaseStat
{
    public int Id { get; set; }

    /// <summary>
    /// The race configuration this base stat belongs to
    /// </summary>
    public int RaceConfigurationId { get; set; }
    public RaceConfiguration RaceConfiguration { get; set; } = null!;

    /// <summary>
    /// The stat being modified
    /// </summary>
    public int StatId { get; set; }
    public Stat Stat { get; set; } = null!;

    /// <summary>
    /// The base modifier value for this stat for this race
    /// </summary>
    public int Value { get; set; }
}

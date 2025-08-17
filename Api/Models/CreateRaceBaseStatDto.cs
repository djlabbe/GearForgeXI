namespace GearForgeXI.Models;

/// <summary>
/// DTO for creating a new race base stat
/// </summary>
public class CreateRaceBaseStatDto
{
    /// <summary>
    /// The stat ID being modified
    /// </summary>
    public int StatId { get; set; }

    /// <summary>
    /// The base modifier value for this stat for this race
    /// </summary>
    public int Value { get; set; }
}

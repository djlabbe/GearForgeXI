using GearForgeXI.Models.Dto;

namespace GearForgeXI.Models;

/// <summary>
/// DTO for race configuration responses
/// </summary>
public class RaceConfigurationDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Abbreviation { get; set; } = string.Empty;
    public List<RaceBaseStatDto> RaceBaseStats { get; set; } = new();
}

/// <summary>
/// DTO for race base stat responses
/// </summary>
public class RaceBaseStatDto
{
    public int Id { get; set; }
    public int RaceConfigurationId { get; set; }
    public int StatId { get; set; }
    public StatDto Stat { get; set; } = null!;
    public int Value { get; set; }
}


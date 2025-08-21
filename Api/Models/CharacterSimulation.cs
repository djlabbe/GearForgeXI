namespace GearForgeXI.Models;

public class CharacterSimulation
{
    public string CharacterName { get; set; } = null!;
    public string Race { get; set; } = null!;
    public string MainJob { get; set; } = null!;
    public int MainJobLevel { get; set; }
    public int MasterLevel { get; set; }
    public string? SubJob { get; set; }
    public int? SubJobLevel { get; set; }
    public string? GearSetName { get; set; }
    public GearSetResponse Gear { get; set; } = null!;

    public DerivedStats DerivedStats { get; set; } = null!;

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

    public DateTime CalculatedAt { get; set; }
}

public class StatModifierDto
{
    public int Value { get; set; }
    public string Source { get; set; } = null!;
}


public class GearSetResponse
{
    public string? Main { get; set; }
    public string? Sub { get; set; }
    public string? Range { get; set; }
    public string? Ammo { get; set; }
    public string? Head { get; set; }
    public string? Neck { get; set; }
    public string? Ear1 { get; set; }
    public string? Ear2 { get; set; }
    public string? Body { get; set; }
    public string? Hands { get; set; }
    public string? Ring1 { get; set; }
    public string? Ring2 { get; set; }
    public string? Back { get; set; }
    public string? Waist { get; set; }
    public string? Legs { get; set; }
    public string? Feet { get; set; }
}

public class DerivedStats
{
    public int MaxHp { get; set; }
    public int MaxMp { get; set; }

    public int PrimaryAccuracy { get; set; }
    public int PrimaryAttack { get; set; }

    public int AuxiliaryAccuracy { get; set; }
    public int AuxiliaryAttack { get; set; }

    public int RangedAccuracy { get; set; }
    public int RangedAttack { get; set; }

    public int TotalEvasion { get; set; }
    public int TotalDefense { get; set; }
}
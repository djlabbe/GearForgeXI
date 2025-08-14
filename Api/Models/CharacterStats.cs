namespace GearForgeXI.Models;

public class CharacterStats
{
    // Core stats
    public int STR { get; set; }
    public int DEX { get; set; }
    public int AGI { get; set; }
    public int VIT { get; set; }
    public int INT { get; set; }
    public int MND { get; set; }
    public int CHR { get; set; }

    // Derived combat stats
    public int Attack { get; set; }
    public int Accuracy { get; set; }
    public int Defense { get; set; }
    public int Evasion { get; set; }
    public int RangedAttack { get; set; }
    public int RangedAccuracy { get; set; }

    // Magic stats
    public int MagicAttack { get; set; }
    public int MagicAccuracy { get; set; }
    public int MagicDefense { get; set; }
    public int MagicEvasion { get; set; }

    // Combat modifiers
    public int DA { get; set; } // Double Attack
    public int TA { get; set; } // Triple Attack
    public int QA { get; set; } // Quadruple Attack
    public int GearHaste { get; set; }
    public int StoreTP { get; set; }
    public int DualWield { get; set; }

    // Defensive stats
    public int DT { get; set; } // Damage Taken
    public int PDT { get; set; } // Physical Damage Taken
    public int MDT { get; set; } // Magic Damage Taken

    // Special abilities/traits
    public List<string> ActiveTraits { get; set; } = new();

    // Dictionary for any additional stats not explicitly defined above
    public Dictionary<string, int> AdditionalStats { get; set; } = new();

    // Track modifiers for debugging/display purposes
    public Dictionary<string, List<StatModifier>> StatModifiers { get; set; } = new();

    public void AddModifier(string statName, int value, string source)
    {
        if (!StatModifiers.ContainsKey(statName))
        {
            StatModifiers[statName] = new List<StatModifier>();
        }

        StatModifiers[statName].Add(new StatModifier
        {
            Value = value,
            Source = source
        });

        // Apply the modifier to the appropriate stat
        ApplyStatModifier(statName, value);
    }

    private void ApplyStatModifier(string statName, int value)
    {
        switch (statName.ToUpper())
        {
            case "STR": STR += value; break;
            case "DEX": DEX += value; break;
            case "AGI": AGI += value; break;
            case "VIT": VIT += value; break;
            case "INT": INT += value; break;
            case "MND": MND += value; break;
            case "CHR": CHR += value; break;
            case "ATTACK": Attack += value; break;
            case "ACCURACY": Accuracy += value; break;
            case "DEFENSE": Defense += value; break;
            case "EVASION": Evasion += value; break;
            case "RANGEDATTACK": RangedAttack += value; break;
            case "RANGEDACCURACY": RangedAccuracy += value; break;
            case "MAGICATTACK": MagicAttack += value; break;
            case "MAGICACCURACY": MagicAccuracy += value; break;
            case "MAGICDEFENSE": MagicDefense += value; break;
            case "MAGICEVASION": MagicEvasion += value; break;
            case "DA": DA += value; break;
            case "TA": TA += value; break;
            case "QA": QA += value; break;
            case "GEARHASTE": GearHaste += value; break;
            case "STORETP": StoreTP += value; break;
            case "DUALWIELD": DualWield += value; break;
            case "DT": DT += value; break;
            case "PDT": PDT += value; break;
            case "MDT": MDT += value; break;
            default:
                // Store in additional stats if not explicitly defined
                if (!AdditionalStats.ContainsKey(statName))
                    AdditionalStats[statName] = 0;
                AdditionalStats[statName] += value;
                break;
        }
    }
}

public class StatModifier
{
    public int Value { get; set; }
    public string Source { get; set; } = null!;
}

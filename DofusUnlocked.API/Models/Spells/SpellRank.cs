namespace DofusUnlocked.API.Models.Spells;

public class SpellRank
{
    public int Id { get; set; } // Primary Key
    public int SpellId { get; set; } // Foreign Key to Spell
    public int RequiredLevel { get; set; } // Required Level to unlock the spell/rank
    public int MinRange { get; set; }
    public int MaxRange { get; set; }
    public bool IsRangeModifiable { get; set; }
    public bool IsLineOfSightRequired { get; set; }
    public bool CastInDiagonal { get; set; }
    public bool CastInLine { get; set; }
    public int APCost { get; set; }
    public int? MaxStack { get; set; }
    public int Cooldown { get; set; }
    public int GlobalCooldown { get; set; }
    public bool CanCastOnEmptyCell { get; set; }
    
    // Navigation properties
    public Spell Spell { get; set; } = null!;
}
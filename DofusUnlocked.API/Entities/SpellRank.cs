public class SpellRank
{
    public int Id { get; set; } // Primary Key
    public int SpellId { get; set; } // Foreign Key to Spell
    public int RequiredLevel { get; set; } // Required Level to unlock the spell/rank
    public int MinRange { get; set; }
    public int MaxRange { get; set; }
    public bool IsRangeModifiable { get; set; }
    public bool IsLineOfSightRequired { get; set; }
    
}
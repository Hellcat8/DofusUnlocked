public class Spell
{
    public int Id { get; set; } // Primary Key
    public required string Name { get; set; } // Spell name
    public required string Description { get; set; } // Spell Description
    
    // Navigation property
    public ICollection<SpellRank> spellRanks{ get; set; } = new List<SpellRank>();
}
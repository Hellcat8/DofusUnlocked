public class Spell
{
    public int Id { get; set; } // Primary Key
    public required string Name { get; set; } // Spell name
    public required string Description { get; set; } // Spell Description
    
    // CharacterClass relation
    public int CharacterClassId { get; set; } // FK to Character Class
    public CharacterClass CharacterClass { get; set; } = null!; // Navigation Property
    
    // Spell to Spell relation (variants)
    public int? VariantSpellId { get; set; } // FK to Spell
    public Spell? VariantSpell { get; set; } // Navigation Property
    
    // SpellRanks relation
    public ICollection<SpellRank> spellRanks{ get; set; } = new List<SpellRank>();
}
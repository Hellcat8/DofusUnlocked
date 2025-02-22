namespace DofusUnlocked.API.Models.Spells;

public class Spell
{
    public int Id { get; set; } // Primary Key
    public required string Name { get; set; } // Spell name
    public required string Description { get; set; } // Spell Description
    public required string ImgUrl { get; set; } // Spell image URL
    
    // CharacterClass relation
    public int CharacterClassId { get; set; } // FK to Character Class
    public CharacterClass CharacterClass { get; set; } = null!; // Navigation Property
    
    // Spell to Spell relation (variants)
    public int? VariantSpellId { get; set; } // FK to Spell
    public Spell? VariantSpell { get; set; } // Navigation Property (from spell A to B)
    public Spell? OriginalSpell { get; set; } // Inverse Navigation Property (from spell B to A)
    
    // SpellRanks relation
    public ICollection<SpellRank> SpellRanks{ get; set; } = new List<SpellRank>();
}
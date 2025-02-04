public class SpellEffect
{
    public int Id { get; set; } // Primary Key

    // Spell Rank relation
    public int SpellRankId { get; set; } // Foreign Key to SpellRank
    public SpellRank SpellRank { get; set; } = null!; // Navigation property

    // Effect Type relation
    public int EffectTypeId { get; set; } // FK to EffectType
    public EffectType EffectType { get; set; } = null!; // Navigation Property

    // Damage Type relation
    public int? DamageTypeId { get; set; } // FK to DamageType
    public DamageType? DamageType { get; set; } // Navigation Property

    // State relation (État pesanteur, invulnérable etc.)
    public int? StateId { get; set; } // FK to State
    public State? State { get; set; } // Navigation Property

    // Specific properties for each effect type
    public int EffectOrder { get; set; } // when a spell has two effects (ex. pushback + damage), this will define which one is displayed first in the list of effects
    public int? MinValue { get; set; } // ex. min damage (>12< to 24 fire damage)
    public int? MaxValue { get; set; } // ex. max damage (12 to >24< fire damage)
    public int? Value { get; set; } // unique value, ex. +2 MP
    public int? Duration { get; set; } // how many turns does the effect last? (ex. poisoned for 2 turns)
    
}
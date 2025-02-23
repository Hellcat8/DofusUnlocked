using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface ISpellRepository
{
    // Spell
    Task<Spell?> CreateSpellAsync(Spell spell);
    Task<IEnumerable<Spell>> GetAllByClassIdAsync(int id);
    Task<Spell?> GetSpellByIdAsync(int id);
    Task<Spell?> UpdateSpellAsync(Spell spell);
    Task<bool> DeleteSpellAsync(Spell spell);
    
    // SpellRank
    Task<SpellRank?> CreateSpellRankAsync(SpellRank spellRank);
    Task<IEnumerable<SpellRank>> GetAllSpellRanksBySpellIdAsync(int id);
    Task<SpellRank?> UpdateSpellRankAsync(SpellRank spellRank);
    Task<bool> DeleteSpellRankAsync(SpellRank spellRank);
    
    // SpellEffect
    Task<SpellEffect?> CreateSpellEffectAsync(SpellEffect spellEffect);
    Task<IEnumerable<SpellEffect>> GetAllSpellEffectsBySpellRankIdAsync(int id);
    Task<SpellEffect?> UpdateSpellEffectAsync(SpellEffect spellEffect);
    Task<bool> DeleteSpellEffectAsync(SpellEffect spellEffect);
}
using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface ISpellRepository
{
    // Spell
    Task<Spell?> CreateSpellAsync(Spell spell);
    Task<IEnumerable<Spell>> GetAllByClassIdAsync(int id);
    Task<Spell?> GetSpellByIdAsync(int id);
    Task<Spell?> UpdateSpellAsync(int id, Spell spell);
    Task<bool> DeleteSpellAsync(int id);
    
    // SpellRank
    Task<SpellRank?> CreateSpellRankAsync(SpellRank spellRank);
    Task<IEnumerable<SpellRank>> GetAllSpellRanksBySpellIdAsync(int id);
    Task<SpellRank?> UpdateSpellRankAsync(int id, SpellRank spellRank);
    Task<bool> DeleteSpellRankAsync(int id);
    
    // SpellEffect
    Task<SpellEffect?> CreateSpellEffectAsync(SpellEffect spellEffect);
    Task<IEnumerable<SpellEffect>> GetAllSpellEffectsBySpellRankIdAsync(int id);
    Task<SpellEffect?> UpdateSpellEffectAsync(int id, SpellEffect spellEffect);
    Task<bool> DeleteSpellEffectAsync(int id);
    
    // Save
    Task SaveAsync();
}
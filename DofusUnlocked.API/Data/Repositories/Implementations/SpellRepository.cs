using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Implementations;

public class SpellRepository : ISpellRepository
{
    private readonly DofusContext _context;

    public SpellRepository(DofusContext dofusContext)
    {
        _context = dofusContext;
    }
    
    #region Spells
    public Task<Spell?> CreateSpellAsync(Spell spell)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Spell>> GetAllByClassIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Spell?> GetSpellByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Spell?> UpdateSpellAsync(Spell spell)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSpellAsync(Spell spell)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region SpellRank
    public Task<SpellRank?> CreateSpellRankAsync(SpellRank spellRank)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SpellRank>> GetAllSpellRanksBySpellIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SpellRank?> UpdateSpellRankAsync(SpellRank spellRank)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSpellRankAsync(SpellRank spellRank)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region SpellEffect
    public Task<SpellEffect?> CreateSpellEffectAsync(SpellEffect spellEffect)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SpellEffect>> GetAllSpellEffectsBySpellRankIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SpellEffect?> UpdateSpellEffectAsync(SpellEffect spellEffect)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSpellEffectAsync(SpellEffect spellEffect)
    {
        throw new NotImplementedException();
    }
    #endregion
}
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
    public async Task<Spell?> CreateSpellAsync(Spell spell)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Spell>> GetAllByClassIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Spell?> GetSpellByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Spell?> UpdateSpellAsync(int id, Spell spell)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteSpellAsync(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region SpellRank
    public async Task<SpellRank?> CreateSpellRankAsync(SpellRank spellRank)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<SpellRank>> GetAllSpellRanksBySpellIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<SpellRank?> UpdateSpellRankAsync(int id, SpellRank spellRank)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteSpellRankAsync(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region SpellEffect
    public async Task<SpellEffect?> CreateSpellEffectAsync(SpellEffect spellEffect)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<SpellEffect>> GetAllSpellEffectsBySpellRankIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<SpellEffect?> UpdateSpellEffectAsync(int id, SpellEffect spellEffect)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteSpellEffectAsync(int id)
    {
        throw new NotImplementedException();
    }
    #endregion
    
    public async Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}
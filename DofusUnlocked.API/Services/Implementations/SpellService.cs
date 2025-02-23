using DofusUnlocked.API.Data.Repositories.Implementations;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Interfaces;

namespace DofusUnlocked.API.Services.Implementations;

public class SpellService : ISpellService
{
    private readonly ISpellRepository _repository;

    public SpellService(ISpellRepository repository)
    {
        _repository = repository;
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
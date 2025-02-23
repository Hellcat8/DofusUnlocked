using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Implementations;

public class CharacterClassRepository : ICharacterClassRepository
{
    private readonly DofusContext _context;

    public CharacterClassRepository(DofusContext context)
    {
        _context = context;
    }

    public Task<CharacterClass?> CreateCharacterClassAsync(CharacterClass characterClass)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CharacterClass>> GetAllCharacterClassesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CharacterClass?> GetCharacterClassByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CharacterClass?> UpdateCharacterClassAsync(CharacterClass characterClass)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterClassAsync(CharacterClass characterClass)
    {
        throw new NotImplementedException();
    }
}
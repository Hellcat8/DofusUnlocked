using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Interfaces;

namespace DofusUnlocked.API.Services.Implementations;

public class CharacterClassService : ICharacterClassService
{
    private readonly ICharacterClassRepository _repository;

    public CharacterClassService(ICharacterClassRepository repository)
    {
        _repository = repository;
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
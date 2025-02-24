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

    public async Task<CharacterClass?> CreateCharacterClassAsync(CharacterClass characterClass)
    {
        return await _repository.CreateCharacterClassAsync(characterClass);
    }

    public async Task<IEnumerable<CharacterClass>> GetAllCharacterClassesAsync()
    {
        return await _repository.GetAllCharacterClassesAsync();
    }

    public async Task<CharacterClass?> GetCharacterClassByIdAsync(int id)
    {
        return await _repository.GetCharacterClassByIdAsync(id);
    }

    public async Task<CharacterClass?> UpdateCharacterClassAsync(int id, CharacterClass characterClass)
    {
        return await _repository.UpdateCharacterClassAsync(id, characterClass);
    }

    public async Task<bool> DeleteCharacterClassAsync(int id)
    {
        return await _repository.DeleteCharacterClassAsync(id);
    }

    public async Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}
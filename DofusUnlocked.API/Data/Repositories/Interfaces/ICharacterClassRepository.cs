using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Data.Repositories.Interfaces;

public interface ICharacterClassRepository
{
    Task<CharacterClass?> CreateCharacterClassAsync(CharacterClass characterClass);
    Task<IEnumerable<CharacterClass>> GetAllCharacterClassesAsync();
    Task<CharacterClass?> GetCharacterClassByIdAsync(int id);
    Task<CharacterClass?> UpdateCharacterClassAsync(int id, CharacterClass characterClass);
    Task<bool> DeleteCharacterClassAsync(int id);
    Task SaveAsync();
}
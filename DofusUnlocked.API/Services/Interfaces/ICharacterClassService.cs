using DofusUnlocked.API.Models.Spells;

namespace DofusUnlocked.API.Services.Interfaces;

public interface ICharacterClassService
{
    /* Amélioration: Replace Model by DTO */
    Task<CharacterClass?> CreateCharacterClassAsync(CharacterClass characterClass);
    Task<IEnumerable<CharacterClass>> GetAllCharacterClassesAsync();
    Task<CharacterClass?> GetCharacterClassByIdAsync(int id);
    Task<CharacterClass?> UpdateCharacterClassAsync(CharacterClass characterClass);
    Task<bool> DeleteCharacterClassAsync(CharacterClass characterClass);
}
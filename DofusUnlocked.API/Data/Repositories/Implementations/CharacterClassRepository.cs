using DofusUnlocked.API.Data.Context;
using DofusUnlocked.API.Data.Repositories.Interfaces;
using DofusUnlocked.API.Models.Spells;
using Microsoft.EntityFrameworkCore;
using Exception = System.Exception;

namespace DofusUnlocked.API.Data.Repositories.Implementations;

public class CharacterClassRepository : ICharacterClassRepository
{
    private readonly DofusContext _context;

    public CharacterClassRepository(DofusContext context)
    {
        _context = context;
    }

    public async Task<CharacterClass?> CreateCharacterClassAsync(CharacterClass characterClass)
    {
        try
        {
            var createdClass = await _context.CharacterClasses.AddAsync(characterClass);
            await SaveAsync();
            return createdClass.Entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<IEnumerable<CharacterClass>> GetAllCharacterClassesAsync()
    {
        try
        {
            return await _context.CharacterClasses.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Enumerable.Empty<CharacterClass>();
        }
    }

    public async Task<CharacterClass?> GetCharacterClassByIdAsync(int id)
    {
        try
        {
            var characterClass = await _context.CharacterClasses.FindAsync(id);
            return characterClass;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<CharacterClass?> UpdateCharacterClassAsync(int id, CharacterClass updatedClass)
    {
        var existingClass = await _context.CharacterClasses.FindAsync(id);
        if (existingClass is null) return null;
        
        existingClass.Name = updatedClass.Name;
        existingClass.ImgUrl = updatedClass.ImgUrl;
        
        try
        {
            await SaveAsync();
            return existingClass;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<bool> DeleteCharacterClassAsync(int id)
    {
        try
        {
            var characterClass = await _context.CharacterClasses.FindAsync(id);
            if (characterClass is null) return false;

            _context.CharacterClasses.Remove(characterClass);
            await SaveAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
using DofusUnlocked.API.Models.Spells;
using DofusUnlocked.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DofusUnlocked.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CharacterClassController : Controller
{
    private readonly ICharacterClassService _service;

    public CharacterClassController(ICharacterClassService service)
    {
        _service = service;
    }

    /// <summary>
    /// Get all classes
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CharacterClass>>> GetAllCharacterClassesAsync()
    {
        var characterClasses = await _service.GetAllCharacterClassesAsync();
        return Ok(characterClasses); // 200 OK
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CharacterClass>> GetCharacterClassByIdAsync(int id)
    {
        var characterClass = await _service.GetCharacterClassByIdAsync(id);
        
        if (characterClass is null) return NotFound(); // 404 NOT FOUND
        return Ok(characterClass); // 200 OK
    }

    [HttpPost]
    public async Task<ActionResult<CharacterClass>> CreateCharacterClassAsync(CharacterClass characterClass)
    {
        var createdClass = await _service.CreateCharacterClassAsync(characterClass);
        
        if (createdClass is null) return BadRequest(); // 400 BAD REQUEST
        
        // 201 CREATED || TEST WITH CREATEDATACTION
        return CreatedAtAction(nameof(GetCharacterClassByIdAsync), new { id = createdClass.Id }, createdClass);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<CharacterClass>> UpdateCharacterClassAsync(int id, CharacterClass characterClass)
    {
        if (id != characterClass.Id) return BadRequest();
        
        if (await _service.GetCharacterClassByIdAsync(id) is null) return NotFound();
        
        var updatedClass = await _service.UpdateCharacterClassAsync(id, characterClass);
        
        if (updatedClass is null) return BadRequest(); // Error when updating entity
        
        // TODO: Return an error if exception (like DbConcurrency)
        
        return NoContent(); // 204 NO CONTENT
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCharacterClassAsync(int id)
    {
        if (await _service.DeleteCharacterClassAsync(id) is false) return NotFound();
        
        return NoContent(); // 204 NO CONTENT
    }
}
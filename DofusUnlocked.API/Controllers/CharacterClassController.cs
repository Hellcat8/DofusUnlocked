using DofusUnlocked.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
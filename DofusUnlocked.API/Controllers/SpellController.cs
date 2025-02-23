using Microsoft.AspNetCore.Mvc;

namespace DofusUnlocked.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SpellController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
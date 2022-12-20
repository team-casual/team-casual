using Microsoft.AspNetCore.Mvc;

namespace TeamCasual.Server.Controllers;

[Route("minecraft")]
[ApiController]
public class MinecraftController : Controller
{
    [HttpGet]
    public IActionResult Hello()
    {
        return Ok("Hello from /minecraft");
    }
}

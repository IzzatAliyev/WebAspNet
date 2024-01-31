using Microsoft.AspNetCore.Mvc;
using Web.Service;

namespace Web.Controller;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    public readonly IAuthService authService;

    public AuthController(IAuthService authService)
    {
        this.authService = authService;
    }

    [HttpGet("login/{username}")]
    public ActionResult Login([FromRoute] string username)
    {
        return this.Ok(authService.Login(username));
    }
}

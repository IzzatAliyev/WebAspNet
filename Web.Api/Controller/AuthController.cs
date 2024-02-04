// Copyright (c) IUA. All rights reserved.

namespace Web.Controller;

using Microsoft.AspNetCore.Mvc;
using Web.Service;

/// <summary>
/// Auth controller.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService authService;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthController"/> class.
    /// </summary>
    /// <param name="authService">the auth service.</param>
    public AuthController(IAuthService authService)
    {
        this.authService = authService;
    }

    /// <summary>
    /// Login the user.
    /// </summary>
    /// <param name="username">the username.</param>
    /// <returns>the token.</returns>
    [HttpGet("login/{username}")]
    public ActionResult Login([FromRoute] string username)
    {
        return this.Ok(this.authService.Login(username));
    }
}

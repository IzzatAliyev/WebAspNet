// Copyright (c) IUA. All rights reserved.

namespace Web.Controller;

using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Web.Attribute;

/// <summary>
/// Secret controller.
/// </summary>
[ApiKey]
[ApiController]
[Route("api/[controller]")]
public class SecretController : ControllerBase
{
    /// <summary>
    /// Get secret.
    /// </summary>
    /// <returns>the result.</returns>
    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    public ActionResult GetSecret()
    {
        return this.Ok("I got secret");
    }
}

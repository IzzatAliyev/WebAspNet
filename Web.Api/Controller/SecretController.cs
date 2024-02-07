// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Controller;

using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Attribute;

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

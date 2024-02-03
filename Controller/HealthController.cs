// Copyright (c) IUA. All rights reserved.

namespace Web.Controller;

using System.Net;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

/// <summary>
/// Health controller.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly ILogger<HealthController> logger;
    private readonly HealthCheckService healthCheckService;

    /// <summary>
    /// Initializes a new instance of the <see cref="HealthController"/> class.
    /// </summary>
    /// <param name="logger">the logger.</param>
    /// <param name="healthCheckService">the healthCheck service.</param>
    public HealthController(ILogger<HealthController> logger, HealthCheckService healthCheckService)
    {
        this.logger = logger;
        this.healthCheckService = healthCheckService;
    }

    /// <summary>
    /// Get result.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    [DisableCors]
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var report = await this.healthCheckService.CheckHealthAsync();

        this.logger.LogInformation($"Get Health Information: {report}");

        return report.Status == HealthStatus.Healthy ? this.Ok(report) : this.StatusCode((int)HttpStatusCode.ServiceUnavailable, report);
    }
}

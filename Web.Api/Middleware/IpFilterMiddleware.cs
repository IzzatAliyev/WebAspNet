// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Middleware;

using System.Net;

/// <summary>
/// Ip filter middleware.
/// </summary>
public class IpFilterMiddleware
{
    private readonly RequestDelegate next;
    private readonly ILogger<IpFilterMiddleware> logger;
    private readonly string allowedIps;

    /// <summary>
    /// Initializes a new instance of the <see cref="IpFilterMiddleware"/> class.
    /// </summary>
    /// <param name="next">the request delegate.</param>
    /// <param name="logger">the logger.</param>
    /// <param name="allowedIps">the allowed ips.</param>
    public IpFilterMiddleware(RequestDelegate next, ILogger<IpFilterMiddleware> logger, string allowedIps)
    {
        this.next = next;
        this.logger = logger;
        this.allowedIps = allowedIps;
    }

    /// <summary>
    /// Invoke method.
    /// </summary>
    /// <param name="context">the httpcontext.</param>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
    public async Task Invoke(HttpContext context)
    {
        var remoteIp = context.Connection.RemoteIpAddress;
        if (!this.IsAlowed(remoteIp))
        {
            this.logger.LogWarning("IP address is not allowed {0}", remoteIp);
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            await context.Response.WriteAsJsonAsync("Forbidden:  IP is not allowed");
            return;
        }

        await this.next(context);
    }

    private bool IsAlowed(IPAddress? ipAddress)
    {
        if (ipAddress is not null)
        {
            return this.allowedIps.Contains(ipAddress.ToString());
        }

        return false;
    }
}

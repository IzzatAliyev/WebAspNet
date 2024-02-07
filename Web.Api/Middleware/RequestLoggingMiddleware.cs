// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Middleware;

/// <summary>
/// Request loggin middleware.
/// </summary>
public class RequestLoggingMiddleware : IMiddleware
{
    private readonly ILogger<RequestLoggingMiddleware> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestLoggingMiddleware"/> class.
    /// </summary>
    /// <param name="logger">the logger.</param>
    public RequestLoggingMiddleware(ILogger<RequestLoggingMiddleware> logger)
    {
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        this.logger.LogInformation($"Received request from ({context.Connection.RemoteIpAddress?.ToString()}): {context.Request.Path}");
        await next(context);
    }
}
// Copyright (c) IUA. All rights reserved.

namespace Web.Middleware;

/// <summary>
/// Request loggin middleware.
/// </summary>
public class RequestLoggingMiddleware
{
    private readonly RequestDelegate next;
    private readonly ILogger<RequestLoggingMiddleware> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestLoggingMiddleware"/> class.
    /// </summary>
    /// <param name="next">the next request delegate.</param>
    /// <param name="logger">the logger.</param>
    public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
    {
        this.next = next;
        this.logger = logger;
    }

    /// <summary>
    /// Invoke method.
    /// </summary>
    /// <param name="context">the http context.</param>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
    public async Task Invoke(HttpContext context)
    {
        this.logger.LogInformation($"Received request from ({context.Connection.RemoteIpAddress?.ToString()}): {context.Request.Path}");
        await this.next(context);
    }
}
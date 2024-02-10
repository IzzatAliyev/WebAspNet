// Copyright (c) IUA. All rights reserved.

namespace Web.Api.HostedService;

/// <summary>
/// Simple console hosted service.
/// </summary>
public class SimpleConsoleHostedService : IHostedService
{
    /// <inheritdoc/>
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Simple console hosted service is starting");
        return Task.CompletedTask;
    }

    /// <inheritdoc/>
    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Simple console hosted service is stopping");
        return Task.CompletedTask;
    }
}

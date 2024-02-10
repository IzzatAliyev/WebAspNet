// Copyright (c) IUA. All rights reserved.

namespace Web.Api.HostedService;

/// <summary>
/// Simple console hosted service.
/// </summary>
public class SimpleConsoleHostedService : IHostedService
{
    /// <inheritdoc/>
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Simple console hosted service is starting");
        await Task.Delay(200, cancellationToken);
    }

    /// <inheritdoc/>
    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

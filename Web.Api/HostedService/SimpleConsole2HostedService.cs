// Copyright (c) IUA. All rights reserved.

namespace Web.Api.HostedService;

/// <summary>
/// Simple console hosted service.
/// </summary>
public class SimpleConsole2HostedService : BackgroundService
{
    /// <inheritdoc/>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Simple console hosted service 2 is starting");
        await Task.Delay(200, stoppingToken);
        throw new Exception("Test exception");
    }
}

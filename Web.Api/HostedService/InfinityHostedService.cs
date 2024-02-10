// Copyright (c) IUA. All rights reserved.

namespace Web.Api.HostedService;

/// <summary>
/// Infinity hosted service.
/// </summary>
public class InfinityHostedService : BackgroundService
{
    /// <inheritdoc/>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine("Infinity loop: " + DateTime.Now);
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }
    }
}

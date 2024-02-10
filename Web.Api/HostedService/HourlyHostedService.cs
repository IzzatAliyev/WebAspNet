// Copyright (c) IUA. All rights reserved.

namespace Web.Api.HostedService;

/// <summary>
/// Hourly hosted service.
/// </summary>
public class HourlyHostedService : BackgroundService
{
    /// <inheritdoc/>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var timer = new PeriodicTimer(TimeSpan.FromHours(1));
        while (await timer.WaitForNextTickAsync(stoppingToken) && !stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine("Hourly job: " + DateTime.Now);
        }
    }
}

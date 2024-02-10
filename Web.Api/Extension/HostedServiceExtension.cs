// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Extension;

using Web.Api.HostedService;

/// <summary>
/// Hosted service extension class.
/// </summary>
public static class HostedServiceExtension
{
    /// <summary>
    /// Add hosted services.
    /// </summary>
    /// <param name="builder">the app builder.</param>
    /// <returns>the service collection.</returns>
    public static IServiceCollection AddHostedServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddHostedService<SimpleConsoleHostedService>();
        builder.Services.AddHostedService<SimpleConsole2HostedService>();
        return builder.Services.AddHostedService<InfinityHostedService>();
    }
}

// Copyright (c) IUA. All rights reserved.

namespace Web.Extension;

/// <summary>
/// Output cache extension class.
/// </summary>
public static class OutputCacheExtension
{
    /// <summary>
    /// Add output cache.
    /// </summary>
    /// <param name="builder">the web application builder.</param>
    public static void AddOutputCache(this WebApplicationBuilder builder)
    {
        builder.Services.AddOutputCache(opt =>
        {
            opt.DefaultExpirationTimeSpan = TimeSpan.FromSeconds(30);
            opt.AddPolicy("Cars", builder => builder.Expire(TimeSpan.FromSeconds(40)));
            opt.AddPolicy("Car", builder => builder.Expire(TimeSpan.FromMinutes(2)));
        });
    }
}

// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Extension;

using Web.Api.Middleware;

/// <summary>
/// Ip filter middleware extension.
/// </summary>
public static class IpFilterMiddlewareExtension
{
    /// <summary>
    /// Use ip filter extension method.
    /// </summary>
    /// <param name="builder">the app builder.</param>
    /// <param name="allowedIps">the allowed ips.</param>
    /// <returns>app builder.</returns>
    public static IApplicationBuilder UseIpFilter(this IApplicationBuilder builder, string allowedIps)
    {
        return builder.UseMiddleware<IpFilterMiddleware>(allowedIps);
    }
}

// Copyright (c) IUA. All rights reserved.

namespace Web.Extension;

using Web.Service;

/// <summary>
/// Service Extension class.
/// </summary>
public static class ServiceExtension
{
    /// <summary>
    /// Add services.
    /// </summary>
    /// <param name="builder">the web application builder.</param>
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IAuthService, AuthService>();
        builder.Services.AddSingleton<IBookService, BookService>();
    }
}

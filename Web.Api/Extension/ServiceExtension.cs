// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Extension;

using Web.Api.Service;

/// <summary>
/// Service Extension class.
/// </summary>
public static class ServiceExtension
{
    /// <summary>
    /// Add services.
    /// </summary>
    /// <param name="builder">the web application builder.</param>
    /// <returns>the service collection.</returns>
    public static IServiceCollection AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IAuthService, AuthService>();
        builder.Services.AddSingleton<IBookService, BookService>();
        builder.Services.AddSingleton<ICommentService, CommentService>();
        return builder.Services.AddScoped<ICarService, CarService>();
    }
}

// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Extension;

using System.Reflection;
using Microsoft.OpenApi.Models;

/// <summary>
/// Swagger extension.
/// </summary>
public static class SwaggerExtension
{
    /// <summary>
    /// Add swagger.
    /// </summary>
    /// <param name="builder">the app builder.</param>
    /// <returns>app builder.</returns>
    public static IServiceCollection AddSwagger(this WebApplicationBuilder builder)
    {
        return builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Web Api",
                Version = "v1",
                Contact = new OpenApiContact { Name = "Izzat" },
                License = new OpenApiLicense { Name = "IUA" },
            });

            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer",
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer",
                        },
                    },
                    Array.Empty<string>()
                },
            });

            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });
    }
}

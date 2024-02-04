// Copyright (c) IUA. All rights reserved.

namespace Web.Extension;

using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

/// <summary>
/// Security extension class.
/// </summary>
public static class SecurityExtension
{
    /// <summary>
    /// Add security.
    /// </summary>
    /// <param name="builder">the web application builder.</param>
    public static void AddSecurity(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = builder.Configuration["ISSUER"],
                ValidateAudience = true,
                ValidAudience = builder.Configuration["AUDIENCE"],
                ValidateLifetime = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["KEY"] !)),
                ValidateIssuerSigningKey = true,
            };
        });
        builder.Services.AddAuthorization();
    }
}

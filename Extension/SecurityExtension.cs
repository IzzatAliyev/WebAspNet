using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Web.Extension;

public static class SecurityExtension
{
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
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["KEY"]!)),
                ValidateIssuerSigningKey = true
            };
        });
        builder.Services.AddAuthorization();
    }
}

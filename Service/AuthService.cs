// Copyright (c) IUA. All rights reserved.

namespace Web.Service;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

/// <summary>
/// Auth service.
/// </summary>
public class AuthService : IAuthService
{
    private readonly IConfiguration configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthService"/> class.
    /// </summary>
    /// <param name="configuration">the configuration class.</param>
    public AuthService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    /// <inheritdoc/>
    public string Login(string username)
    {
        var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
        var jwt = new JwtSecurityToken(
            issuer: this.configuration["ISSUER"],
            audience: this.configuration["AUDIENCE"],
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["KEY"] !)), SecurityAlgorithms.HmacSha256));
        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}

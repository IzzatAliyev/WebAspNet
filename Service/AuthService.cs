using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Web.Service;

public class AuthService : IAuthService
{
    private readonly IConfiguration configuration;
    public AuthService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    public string Login(string username)
    {
        var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
        var jwt = new JwtSecurityToken(
            issuer: configuration["ISSUER"],
            audience: configuration["AUDIENCE"],
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["KEY"]!)), SecurityAlgorithms.HmacSha256));
        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}

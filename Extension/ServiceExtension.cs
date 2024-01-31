using Web.Service;

namespace Web.Extension;

public static class ServiceExtension
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IAuthService, AuthService>();
        builder.Services.AddSingleton<IBookService, BookService>();
    }
}

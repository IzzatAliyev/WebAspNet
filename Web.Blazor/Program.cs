// Copyright (c) IUA. All rights reserved.

namespace Web.Blazor;

using Web.Blazor.Components;

/// <summary>
/// Starting class.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the program.
    /// </summary>
    /// <param name="args">the args.</param>
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        System.Console.WriteLine(typeof(Program).Assembly);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);

            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
            app.UseHttpsRedirection();
        }

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}

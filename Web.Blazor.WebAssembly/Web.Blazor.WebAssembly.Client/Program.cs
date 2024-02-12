// Copyright (c) IUA. All rights reserved.

namespace Web.Blazor.WebAssembly.Client;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

/// <summary>
/// Starting class.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the program.
    /// </summary>
    /// <param name="args">the args.</param>
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        await builder.Build().RunAsync();
    }
}

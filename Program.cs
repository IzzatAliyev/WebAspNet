// Copyright (c) IUA. All rights reserved.

namespace Web;

using Web.Extension;
using Web.Middleware;

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

    // Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddHealthChecks();
    builder.AddServices();
    builder.AddSecurity();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
      app.UseSwagger();
      app.UseSwaggerUI();
    }

    app.UseMiddleware<RequestLoggingMiddleware>();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();

    // app.UseHttpsRedirection();
    app.Run();
  }
}
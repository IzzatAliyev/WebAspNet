// Copyright (c) IUA. All rights reserved.

namespace Web;

using Web.DB;
using Web.Extension;
using Web.Handler;
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
    var allowOriginCorsPolicyName = "AllowOriginCors";

    // Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddHealthChecks();
    builder.AddOutputCache();
    builder.AddServices();
    builder.AddSecurity();
    builder.AddCors(allowOriginCorsPolicyName);
    builder.Services.AddDbContext<AppDbContext>();
    builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
    builder.Services.AddProblemDetails();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
      app.UseSwagger();
      app.UseSwaggerUI();
    }
    else
    {
      app.UseHttpsRedirection();
    }

    app.UseCors(allowOriginCorsPolicyName);
    app.UseOutputCache();
    app.UseExceptionHandler();
    app.UseMiddleware<RequestLoggingMiddleware>();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
  }
}
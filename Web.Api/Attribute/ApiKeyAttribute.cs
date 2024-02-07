// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Attribute;

using System;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Filters;

/// <summary>
/// Api key attribute.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ApiKeyAttribute : Attribute, IAsyncActionFilter
{
    private const string ApiKey = "X-API-KEY";

    /// <inheritdoc/>
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.HttpContext.Request.Headers.TryGetValue(ApiKey, out var apiKeyVal))
        {
            context.HttpContext.Response.StatusCode = 401;
            context.HttpContext.Response.ContentType = MediaTypeNames.Application.Json;
            await context.HttpContext.Response.WriteAsync("Api Key not found!");
            return;
        }

        var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
        var apiKey = appSettings.GetValue<string>(ApiKey);
        if (!apiKey!.Equals(apiKeyVal))
        {
            context.HttpContext.Response.StatusCode = 401;
            context.HttpContext.Response.ContentType = MediaTypeNames.Application.Json;
            await context.HttpContext.Response.WriteAsync("Unauthorized client");
            return;
        }

        await next();
    }
}

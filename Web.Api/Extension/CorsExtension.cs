// Copyright (c) IUA. All rights reserved.

namespace Web.Extension;

/// <summary>
/// Cors extension class.
/// </summary>
public static class CorsExtension
{
    /// <summary>
    /// Add cors.
    /// </summary>
    /// <param name="builder">the web application builder.</param>
    /// <param name="policyName">the policy name.</param>
    public static void AddCors(this WebApplicationBuilder builder, string policyName)
    {
        builder.Services.AddCors(opt =>
        {
            opt.AddPolicy(policyName, policy =>
            {
                policy.WithOrigins("https://www.jsondataai.com").AllowAnyHeader().AllowAnyMethod();
            });

            opt.AddPolicy(policyName, policy =>
            {
                policy.WithOrigins("https://www.google.com").AllowAnyHeader().WithMethods("Get", "Post");
            });

            // For debuging purpose only
            // opt.AddPolicy(policyName, policy =>
            // {
            //     policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            // });
        });
    }
}

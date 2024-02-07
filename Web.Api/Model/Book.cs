// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Model;

using System.Text.Json.Serialization;

/// <summary>
/// Book model.
/// </summary>
public class Book
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the post.
    /// </summary>
    [JsonPropertyName("post")]
    public string? Post { get; set; }
}

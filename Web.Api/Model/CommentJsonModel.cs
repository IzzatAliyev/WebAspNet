// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Model;

using System.Text.Json.Serialization;

/// <summary>
/// Comment json model.
/// </summary>
public class CommentJsonModel
{
    /// <summary>
    /// Gets or sets the postId.
    /// </summary>
    [JsonPropertyName("postId")]
    public int PostId { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets the body.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }
}
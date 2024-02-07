// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Service;

using Web.Api.Constant;
using Web.Api.Model;

/// <summary>
/// Comment service.
/// </summary>
public class CommentService : ICommentService
{
    private readonly IHttpClientFactory httpClientFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommentService"/> class.
    /// </summary>
    /// <param name="httpClientFactory">the http client factory.</param>
    public CommentService(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    private HttpClient HttpClient => this.httpClientFactory.CreateClient(HttpClientName.Comment.ToString());

    /// <inheritdoc/>
    public async Task<List<CommentJsonModel>> GetComments()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "/comments");
        var response = await this.HttpClient.SendAsync(request);

        var comments = await response.Content.ReadFromJsonAsync<List<CommentJsonModel>>();
        return comments ?? throw new Exception("Comments not found");
    }
}

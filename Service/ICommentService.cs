// Copyright (c) IUA. All rights reserved.

namespace Web.Service;

using Web.Model;

/// <summary>
/// Interface for comment service.
/// </summary>
public interface ICommentService
{
    /// <summary>
    /// Get comments.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public Task<List<CommentJsonModel>> GetComments();
}

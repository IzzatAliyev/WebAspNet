// Copyright (c) IUA. All rights reserved.

namespace Web.Controller;

using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Web.Service;

/// <summary>
/// Comment controller.
/// </summary>
[OutputCache(PolicyName = "Comment")]
[ApiController]
[Route("api/[controller]")]
public class CommentController(ICommentService commentService)
: ControllerBase
{
    private readonly ICommentService commentService = commentService;

    /// <summary>
    /// Get all comments.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<ActionResult> GetAll()
    {
        return this.Ok(await this.commentService.GetComments());
    }
}

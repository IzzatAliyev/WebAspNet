// Copyright (c) IUA. All rights reserved.

namespace Web.Controller;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Service;

/// <summary>
/// Book controller.
/// </summary>
[Authorize]
[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService bookService;

    /// <summary>
    /// Initializes a new instance of the <see cref="BookController"/> class.
    /// </summary>
    /// <param name="bookService">the book service.</param>
    public BookController(IBookService bookService)
    {
        this.bookService = bookService;
    }

    /// <summary>
    /// Get all books.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    [HttpGet]
    [Produces("application/json")]
    public async Task<ActionResult> GetBooks()
    {
        return this.Ok(await this.bookService.GetBooks());
    }

    /// <summary>
    /// Get book.
    /// </summary>
    /// <param name="id">the id of book.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    [HttpGet("{id}")]
    [Produces("application/json")]
    public async Task<ActionResult> GetBook([FromRoute] string id)
    {
        return this.Ok(await this.bookService.GetBook(id));
    }
}

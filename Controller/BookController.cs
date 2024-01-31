using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Service;

namespace Web.Controller;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService bookService;
    public BookController(IBookService bookService)
    {
        this.bookService = bookService;
    }

    [Authorize]
    [HttpGet]
    [Produces("application/json")]
    public async Task<ActionResult> GetBooks()
    {
        return this.Ok(await bookService.GetBooks());
    }

    [Authorize]
    [HttpGet("{id}")]
    [Produces("application/json")]
    public async Task<ActionResult> GetBook([FromRoute] string id)
    {
        return this.Ok(await bookService.GetBook(id));
    }
}

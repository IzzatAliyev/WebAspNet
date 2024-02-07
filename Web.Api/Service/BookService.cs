// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Service;

using System.Text.Json;
using Web.Api.Model;

/// <summary>
/// Book service.
/// </summary>
public class BookService : IBookService
{
    /// <inheritdoc/>
    public async Task<Book> GetBook(string id)
    {
        using var read = new FileStream("./DB/books.json", FileMode.Open);
        var books = await JsonSerializer.DeserializeAsync<Book[]>(read);
        var book = books!.First(x => x.Id == id);
        return book;
    }

    /// <inheritdoc/>
    public async Task<List<Book>> GetBooks()
    {
        using var read = new FileStream("./DB/books.json", FileMode.Open);
        List<Book>? books = await JsonSerializer.DeserializeAsync<List<Book>>(read);
        return books!;
    }
}

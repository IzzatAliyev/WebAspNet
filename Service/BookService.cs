using System.Text.Json;
using Web.Model;

namespace Web.Service;

public class BookService : IBookService
{
    public async Task<Book> GetBook(string id)
    {
        using var read = new FileStream("./DB/books.json", FileMode.Open);
        Book[]? books = await JsonSerializer.DeserializeAsync<Book[]>(read);
        var book = books!.First(x => x.Id == id);
        return book;
    }

    public async Task<List<Book>> GetBooks()
    {
        using var read = new FileStream("./DB/books.json", FileMode.Open);
        List<Book>? books = await JsonSerializer.DeserializeAsync<List<Book>>(read);
        return books!;
    }
}

using Web.Model;

namespace Web.Service;

public interface IBookService
{
    public Task<List<Book>> GetBooks();
    public Task<Book> GetBook(string id);
}

// Copyright (c) IUA. All rights reserved.

namespace Web.Service;

using Web.Model;

/// <summary>
/// Interface for Book service.
/// </summary>
public interface IBookService
{
    /// <summary>
    /// Get all books.
    /// </summary>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public Task<List<Book>> GetBooks();

    /// <summary>
    /// Get book.
    /// </summary>
    /// <param name="id">the book id.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public Task<Book> GetBook(string id);
}

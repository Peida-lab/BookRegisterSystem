using BookRegister.Domain.Books;
using BookRegister.Infrastructure.Stores;

namespace BookRegister.Infrastructure.Repositories;

public class InMemoryBookRepository : IBookRepository
{
    public bool Create(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);

        InMemoryBookStore.Books.Add(book);

        return true;
    }

    public IReadOnlyList<Book> GetAll()
    {
        var books = InMemoryBookStore.Books;

        return books;
    }

    public Book? GetById(Guid bookId)
    {
        var book = InMemoryBookStore.Books.FirstOrDefault(book => book.BookId == bookId);

        return book;
    }

    public bool Update(Book book)
    {
        var index = InMemoryBookStore.Books.FindIndex(
            b => b.BookId == book.BookId
        );
        if (index == -1)
            throw new ArgumentException("Book was not found");

        InMemoryBookStore.Books[index] = book;

        return true;
    }

    public bool Delete(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);
        InMemoryBookStore.Books.Remove(book);

        return true;

    }


}
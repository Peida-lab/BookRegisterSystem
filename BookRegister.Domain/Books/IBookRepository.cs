namespace BookRegister.Domain.Books;

public interface IBookRepository
{
    bool Create(Book book);
    bool Delete(Book book);
    IReadOnlyList<Book> GetAll();
    Book? GetById(Guid bookId);
    bool Update(Book book);
}

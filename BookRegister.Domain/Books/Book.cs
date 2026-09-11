namespace BookRegister.Domain.Books;

public class Book(Guid bookId, string bookName, string bookGenre)
{
    public Guid BookId { get; private set; } = NormalizeRequiredBookId(bookId);
    public string BookName { get; private set; } = NormalizeRequiredBookName(bookName);
    public string BookGenre { get; private set; } = NormalizeRequiredBookGenre(bookGenre);



    private static Guid NormalizeRequiredBookId(Guid bookId)
    {
        if (bookId == Guid.Empty)
            throw new ArgumentException("Book ID is required");
        return bookId;
    }

    private static string NormalizeRequiredBookName(string bookName)
    {
        if (string.IsNullOrWhiteSpace(bookName))
            throw new ArgumentException("Book name is required");
        bookName = bookName.Trim();
        return bookName;
    }

    private static string NormalizeRequiredBookGenre(string bookGenre)
    {
        if (string.IsNullOrWhiteSpace(bookGenre))
            throw new ArgumentException("Book genre is required");
        bookGenre = bookGenre.Trim();
        return bookGenre;
    }

}
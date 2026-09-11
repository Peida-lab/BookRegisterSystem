using BookRegister.Application.Features.Books.Dtos.Requests;
using BookRegister.Application.Features.Books.Dtos.Results;
using BookRegister.Domain.Books;

namespace BookRegister.Application.Features.Books;

internal class BookService(IBookRepository bookRepository)
{
    public CreateBookResult CreateBook(CreateBookRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Book book;
        try
        {
            var bookId = Guid.NewGuid();

            book = new Book
            (
                bookId, 
                request.BookName, 
                request.BookGenre
            );
        }


        catch (Exception ex)
        {
            return new CreateBookResult(
                false, 
                null, 
                ex.Message
            );
        }

        bool saved = bookRepository.Create(book);

        if(saved)
        {
            return new CreateBookResult
            (
                true, 
                book, 
                null
            );
        }

        return new CreateBookResult
        (
            false,
            null,
            "Unable to save book"
        );
    }
}
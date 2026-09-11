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

        if (saved)
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
    public GetAllBooksResult GetAllBooks()
    {
        var books = bookRepository.GetAll();

        return new GetAllBooksResult(
            true,
            books,
            null
        );
    }

    public GetBookResult GetBookById(Guid bookId)
    {
        var book = bookRepository.GetById(bookId);

        if (book is null)
        {
            return new GetBookResult(
                false,
                null,
                $"Book with id '{bookId}' was not found"
            );
        }

        return new GetBookResult(
            true,
            book,
            null
        );
    }

    public UpdateBookResult UpdateBook(UpdateBookRequest request)
{
    ArgumentNullException.ThrowIfNull(request);

    var book = bookRepository.GetById(request.UpdatedBook.BookId);

    if (book is null)
    {
        return new UpdateBookResult(
            false,
            null,
            $"Book with id '{request.UpdatedBook.BookId}' was not found"
        );
    }

    var updated = bookRepository.Update(request.UpdatedBook);

    if (updated)
    {
        return new UpdateBookResult(
            true,
            request.UpdatedBook,
            null
        );
    }

    return new UpdateBookResult(
        false,
        null,
        "Unable to update book"
    );
}
}
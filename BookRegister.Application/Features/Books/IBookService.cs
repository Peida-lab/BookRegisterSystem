using BookRegister.Application.Features.Books.Dtos.Requests;
using BookRegister.Application.Features.Books.Dtos.Results;

namespace BookRegister.Application.Features.Books;

public interface IBookService
{
    CreateBookResult CreateBook(CreateBookRequest request);
    DeleteBookResult DeleteBookById(Guid bookId);
    GetAllBooksResult GetAllBooks();
    GetBookResult GetBookById(Guid bookId);
    UpdateBookResult UpdateBook(UpdateBookRequest request);
}

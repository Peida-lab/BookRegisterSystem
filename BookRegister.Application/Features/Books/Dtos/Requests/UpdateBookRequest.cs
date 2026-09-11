using BookRegister.Domain.Books;

namespace BookRegister.Application.Features.Books.Dtos.Requests;

public record UpdateBookRequest
(
    Book UpdatedBook
);
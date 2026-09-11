using BookRegister.Domain.Books;

namespace BookRegister.Application.Features.Books.Dtos.Results;

public record GetAllBooksResult
(
    bool Succeeded,
    IReadOnlyList<Book> Books,
    string? ErrorMessage
);
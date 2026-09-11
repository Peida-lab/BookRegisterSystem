using BookRegister.Domain.Books;

namespace BookRegister.Application.Features.Books.Dtos.Results;

public record UpdateBookResult
(
    bool Succeeded,
    Book? Book,
    string? ErrorMessage
);
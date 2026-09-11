using BookRegister.Domain.Books;

namespace BookRegister.Application.Features.Books.Dtos.Results;

public record GetBookResult
(
    bool Succeeded,
    Book? Book,
    string? ErrorMessage
);
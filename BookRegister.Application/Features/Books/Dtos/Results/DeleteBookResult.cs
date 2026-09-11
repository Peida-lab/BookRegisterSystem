namespace BookRegister.Application.Features.Books.Dtos.Results;

public record DeleteBookResult
(
    bool Succeeded,
    string? ErrorMessage
);
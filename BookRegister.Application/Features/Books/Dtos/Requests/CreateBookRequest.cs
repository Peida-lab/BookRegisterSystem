namespace BookRegister.Application.Features.Books.Dtos.Requests;
public record CreateBookRequest
(
    string BookName,
    string BookGenre
);
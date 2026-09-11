using System.Dynamic;
using BookRegister.Domain.Books;

namespace BookRegister.Infrastructure.Stores;

internal static class InMemoryBookStore
{
    public static List<Book> Books { get; set; } = [];

}
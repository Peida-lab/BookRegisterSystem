using BookRegister.Application.Features.Books;
using BookRegister.Application.Features.Books.Dtos.Requests;

namespace BookRegister.Presentation.Dialogs;

internal class BookDialog(IBookService bookService)
{
    public void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("BOOK REGISTER");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Show books");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Choose: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateBookDialog();
                    break;

                case "2":
                    ViewBooksDialog();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void CreateBookDialog()
    {
        Console.Clear();

        Console.Write("Book name: ");
        string bookName = Console.ReadLine() ?? "";

        Console.Write("Book genre: ");
        string bookGenre = Console.ReadLine() ?? "";

        var request = new CreateBookRequest(
            bookName,
            bookGenre
        );

        var result = bookService.CreateBook(request);

        if (!result.Succeeded)
        {
            Console.WriteLine(result.ErrorMessage);
        }
        else
        {
            Console.WriteLine("Book was created!");
        }

        Console.ReadKey();
    }

    private void ViewBooksDialog()
    {
        Console.Clear();

        var result = bookService.GetAllBooks();

        foreach (var book in result.Books)
        {
            Console.WriteLine($"{book.BookName} - {book.BookGenre}");
        }

        Console.ReadKey();
    }
}
using BookRegister.Application.Features.Books;
using Microsoft.Extensions.DependencyInjection;

namespace BookRegister.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IBookService, BookService>();

        return services;
    }
}
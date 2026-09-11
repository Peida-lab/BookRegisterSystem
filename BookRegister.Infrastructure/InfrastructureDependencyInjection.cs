using BookRegister.Domain.Books;
using BookRegister.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BookRegister.Infrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IBookRepository, InMemoryBookRepository>();

        return services;
    }
}
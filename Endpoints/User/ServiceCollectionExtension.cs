using Endpoints.User.Abstract.Repository;
using Endpoints.User.Database.Context;
using Endpoints.User.Database.Repository;
using Endpoints.User.Requests.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Endpoints.User;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterUserServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(TestQuery).Assembly));
        services.AddContext();
        services.AddRepositories();
        return services;
    }

    private static void AddContext(this IServiceCollection services)
    {
        services.AddSingleton<UsersContext>();
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IUserRepository, UserRepository>();
    }
}
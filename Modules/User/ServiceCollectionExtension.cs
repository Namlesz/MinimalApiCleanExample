using Microsoft.Extensions.DependencyInjection;
using User.Abstract.Repository;
using User.Database.Context;
using User.Database.Repository;
using User.Requests.Queries;

namespace User;

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
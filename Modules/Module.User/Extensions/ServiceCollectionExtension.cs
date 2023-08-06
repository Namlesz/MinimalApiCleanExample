using Microsoft.Extensions.DependencyInjection;
using Module.User.Abstract.Repository;
using Module.User.Database.Context;
using Module.User.Database.Repository;
using System.Reflection;

namespace Module.User.Extensions;

internal static class ServiceCollectionExtension
{
    internal static void RegisterServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddContext();
        services.AddRepositories();
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
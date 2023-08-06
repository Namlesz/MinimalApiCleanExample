using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Todos.Extensions;

internal static class ServiceCollectionExtension
{
    internal static void RegisterServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}
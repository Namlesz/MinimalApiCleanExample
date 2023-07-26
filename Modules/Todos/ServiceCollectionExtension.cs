using Microsoft.Extensions.DependencyInjection;
using Todos.Request.Query;

namespace Todos;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterTodoServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(TodosQuery).Assembly));
        return services;
    }
}
using Endpoints.Todo.Request.Query;
using Microsoft.Extensions.DependencyInjection;

namespace Endpoints.Todo;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterTodoServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(TodosQuery).Assembly));
        return services;
    }
}
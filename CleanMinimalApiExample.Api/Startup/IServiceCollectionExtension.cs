using Endpoints.Todo.Request.Query;
using Endpoints.User.Requests.Queries;

namespace CleanMinimalApiExample.Startup;

public static class IServiceCollectionExtension
{
    public static IServiceCollection RegisterApiServices(this IServiceCollection services)
    {
        services.RegisterMediatR();
        return services;
    }

    private static void RegisterMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
            typeof(TodosQuery).Assembly,
            typeof(TestQuery).Assembly
        ));
    }
}
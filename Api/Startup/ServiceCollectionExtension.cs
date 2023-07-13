using Endpoints.Todo.Request.Query;
using Endpoints.User.Requests.Queries;
using Microsoft.OpenApi.Models;

namespace CleanMinimalApiExample.Startup;

public static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterApiServices(this IServiceCollection services)
    {
        services.RegisterMediatR();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Clean minimal Api example",
                Version = "v1",
                Description = "Sample minimal Api for using .NET 8."
            });
        });
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
using Microsoft.OpenApi.Models;

namespace CleanMinimalApiExample.Startup;

internal static class ServiceCollectionExtension
{
    public static IServiceCollection RegisterApiServices(this IServiceCollection services)
    {
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
}
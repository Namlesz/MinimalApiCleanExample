using Shared.Abstract;

namespace CleanMinimalApiExample.Startup;

internal static class WebApplicationExtension
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();

        var classes = assemblies
            .Distinct()
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IEndpoint).IsAssignableFrom(x) && x is { IsInterface: false, IsAbstract: false });

        foreach (var classe in classes)
        {
            var instance = Activator.CreateInstance(classe) as IEndpoint;
            instance?.EndpointsMapper(app);
        }

        return app;
    }

    public static WebApplication UseSwaggerConfig(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        return app;
    }
}
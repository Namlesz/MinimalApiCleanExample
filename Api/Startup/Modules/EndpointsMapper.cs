using Shared.Abstract;

namespace CleanMinimalApiExample.Startup.Modules;

public static class EndpointsMapper
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
}
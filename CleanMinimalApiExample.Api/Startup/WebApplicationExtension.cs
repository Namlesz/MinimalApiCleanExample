using CleanMinimalApiExample.Abstract;

namespace CleanMinimalApiExample.Startup;

public static class WebApplicationExtension
{
    public static void MapEndpoints(this WebApplication app)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();

        var classes = assemblies
            .Distinct()
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IEndpoints).IsAssignableFrom(x) && x is { IsInterface: false, IsAbstract: false });

        foreach (var classe in classes)
        {
            var instance = Activator.CreateInstance(classe) as IEndpoints;
            instance?.EndpointsMapper(app);
        }
    }
}
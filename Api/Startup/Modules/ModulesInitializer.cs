using Shared.Abstract;
using System.Reflection;

namespace CleanMinimalApiExample.Startup.Modules;

public static class ModulesInitializer
{
    public static IServiceCollection RegisterModules(this IServiceCollection services)
    {
        var assemblies = Directory
            .GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Module.*.dll")
            .Select(Assembly.LoadFrom)
            .ToList();

        var classes = assemblies
            .Distinct()
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IModuleInitializer).IsAssignableFrom(x) && x is { IsInterface: false, IsAbstract: false });

        foreach (var classe in classes)
        {
            var instance = Activator.CreateInstance(classe) as IModuleInitializer;
            instance?.Init(services);
        }

        return services;
    }
}
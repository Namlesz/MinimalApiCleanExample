using Microsoft.Extensions.DependencyInjection;
using Shared.Abstract;
using Todos.Extensions;

namespace Todos;

public sealed class ModuleInit : IModuleInitializer
{
    public void Init(IServiceCollection services)
    {
        services.RegisterServices();
    }
}
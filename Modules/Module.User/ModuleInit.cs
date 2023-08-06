using Microsoft.Extensions.DependencyInjection;
using Module.User.Extensions;
using Shared.Abstract;

namespace Module.User;

public class ModuleInit : IModuleInitializer
{
    public void Init(IServiceCollection services)
    {
        services.RegisterServices();
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Abstract;

public interface IModuleInitializer
{
    public void Init(IServiceCollection services);
}
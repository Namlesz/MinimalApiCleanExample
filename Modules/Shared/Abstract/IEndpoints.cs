using Microsoft.AspNetCore.Builder;

namespace Shared.Abstract;

public interface IEndpoint
{
    public void EndpointsMapper(WebApplication app);
}
using CleanMinimalApiExample.Abstract;
using Endpoints.User.Requests.Queries;
using MediatR;

namespace CleanMinimalApiExample.Endpoints;

public class UserEndpoints : IEndpoints
{
    public void EndpointsMapper(WebApplication app)
    {
        app.MapGet("/test", GetToDos);
    }

    private async static Task<IResult> GetToDos(IMediator mediator)
    {
        var res = await mediator.Send(new TestQuery());
        return Results.Ok(res);
    }
}
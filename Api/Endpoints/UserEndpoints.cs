using CleanMinimalApiExample.Abstract;
using Endpoints.User.Requests.Queries;
using MediatR;

namespace CleanMinimalApiExample.Endpoints;

public class UserEndpoints : IEndpoints
{
    public void EndpointsMapper(WebApplication app)
    {
        var prefix = app.MapGroup("/")
            .WithOpenApi();
        
        prefix.MapGet("/test", GetToDos)
            .WithSummary("Get test string")
            .WithDescription("Get defined string from backend")
            .Produces<string>();
    }

    private async static Task<IResult> GetToDos(IMediator mediator)
    {
        var res = await mediator.Send(new TestQuery());
        return Results.Ok(res);
    }
}
using CleanMinimalApiExample.Abstract;
using Endpoints.User.Models;
using Endpoints.User.Requests.Queries;
using MediatR;

namespace CleanMinimalApiExample.Endpoints;

internal sealed class UserEndpoints : IEndpoints
{
    public void EndpointsMapper(WebApplication app)
    {
        var prefix = app.MapGroup("/")
            .WithOpenApi();

        prefix.MapGet("/test", GetToDos)
            .WithSummary("Get test string")
            .WithDescription("Get defined string from backend")
            .Produces<string>();

        prefix.MapGet("/users", GetAllUsers)
            .WithSummary("Get all users")
            .WithDescription("Get all users from database")
            .Produces<List<UserDto>>();
    }

    private async static Task<IResult> GetToDos(IMediator mediator)
    {
        var res = await mediator.Send(new TestQuery());
        return Results.Ok(res);
    }

    private async static Task<IResult> GetAllUsers(IMediator mediator)
    {
        var res = await mediator.Send(new GetAllUsersQuery());
        return Results.Ok(res);
    }
}
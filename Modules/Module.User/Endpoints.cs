using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Module.User.Models;
using Module.User.Requests.Queries;
using Shared.Abstract;

namespace Module.User;

internal sealed class Endpoints : IEndpoint
{
    public void EndpointsMapper(WebApplication app)
    {
        var prefix = app.MapGroup("/")
            .WithOpenApi()
            .WithTags("User");

        prefix.MapGet("/test", GetToDos)
            .WithSummary("Get test string")
            .WithDescription("Get defined string from backend")
            .Produces<string>();

        prefix.MapGet("/users", GetAllUsers)
            .WithSummary("Get all users")
            .WithDescription("Get all users from database")
            .Produces<List<UserDto>>();
    }

    private static async Task<IResult> GetToDos(IMediator mediator)
    {
        var res = await mediator.Send(new TestQuery());
        return Results.Ok(res);
    }

    private static async Task<IResult> GetAllUsers(IMediator mediator)
    {
        var res = await mediator.Send(new GetAllUsersQuery());
        return Results.Ok(res);
    }
}
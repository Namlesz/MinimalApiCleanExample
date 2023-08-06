using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Shared.Abstract;
using Todos.Request.Query;

namespace Todos;

internal sealed class Endpoints : IEndpoint
{
    public void EndpointsMapper(WebApplication app)
    {
        var prefix = app.MapGroup("/todos")
            .WithOpenApi()
            .WithTags("Todos");

        prefix.MapGet("/", GetTodos)
            .WithSummary("Get all todos")
            .WithDescription("Get all random todos")
            .Produces<Models.Todos[]>();

        prefix.MapGet("/{id:int}", GetTodoById)
            .WithSummary("Get all todos")
            .WithDescription("Get one random generated todo by id")
            .Produces<Models.Todos>()
            .Produces(StatusCodes.Status404NotFound);
    }

    private static async Task<IResult> GetTodoById(int id, IMediator mediator)
    {
        var res = await mediator.Send(new GetTodosQuery(id));
        return res is null
            ? Results.NotFound()
            : Results.Ok(res);
    }

    private static async Task<IResult> GetTodos(IMediator mediator)
    {
        var res = await mediator.Send(new TodosQuery());
        return Results.Ok(res);
    }
}
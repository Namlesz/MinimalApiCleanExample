using CleanMinimalApiExample.Abstract;
using Endpoints.Todo.Models;
using Endpoints.Todo.Request.Query;
using MediatR;

namespace CleanMinimalApiExample.Endpoints;

internal sealed class TodosEndpoints : IEndpoints
{
    public void EndpointsMapper(WebApplication app)
    {
        var prefix = app.MapGroup("/todos")
            .WithOpenApi();

        prefix.MapGet("/", GetTodos)
            .WithSummary("Get all todos")
            .WithDescription("Get all random todos")
            .Produces<Todos[]>();

        prefix.MapGet("/{id}", GetTodoById)
            .WithSummary("Get all todos")
            .WithDescription("Get one random generated todo by id")
            .Produces<Todos>()
            .Produces(StatusCodes.Status404NotFound);
    }

    private async static Task<IResult> GetTodoById(int id, IMediator mediator)
    {
        var res = await mediator.Send(new GetTodosQuery(id));
        return res is null
            ? Results.NotFound()
            : Results.Ok(res);
    }

    private async Task<IResult> GetTodos(IMediator mediator)
    {
        var res = await mediator.Send(new TodosQuery());
        return Results.Ok(res);
    }
}
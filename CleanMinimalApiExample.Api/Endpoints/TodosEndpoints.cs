using CleanMinimalApiExample.Abstract;
using Endpoints.Todo.Request.Query;
using MediatR;

namespace CleanMinimalApiExample.Endpoints;

public class TodosEndpoints : IEndpoints
{
    public void EndpointsMapper(WebApplication app)
    {
        var prefix = app.MapGroup("/todos");
        prefix.MapGet("/", GetTodos);
        prefix.MapGet("/{id}", GetTodoById);
    }

    private async static Task<IResult> GetTodoById(int id, HttpContext context, IMediator mediator)
    {
        var res = await mediator.Send(new GetTodosQuery(id));
        return res is null
            ? Results.NotFound()
            : Results.Ok(res);
    }

    public async Task<IResult> GetTodos(HttpContext context, IMediator mediator)
    {
        var res = await mediator.Send(new TodosQuery());
        return Results.Ok(res);
    }
}
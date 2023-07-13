using Endpoints.Todo.Request.Query;
using Endpoints.Todo.Services;
using MediatR;

namespace Endpoints.Todo.Handlers.Query;

public class TodosQueryHandler : IRequestHandler<TodosQuery, Todos[]>
{
    public Task<Todos[]> Handle(TodosQuery request, CancellationToken cancellationToken)
    {
        var sampleTodos = TodoGenerator.GenerateTodos().ToArray();
        return Task.FromResult(sampleTodos);
    }
}
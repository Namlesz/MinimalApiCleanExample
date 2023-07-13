using Endpoints.Todo.Request.Query;
using Endpoints.Todo.Services;
using MediatR;

namespace Endpoints.Todo.Handlers.Query;

public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, Todos?>
{
    public Task<Todos?> Handle(GetTodosQuery request, CancellationToken cancellationToken)
    {
        var sampleTodos = TodoGenerator.GenerateTodos().ToArray();
        var todo = sampleTodos.FirstOrDefault(a => a.Id == request.Id);
        return Task.FromResult(todo);
    }
}
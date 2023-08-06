using MediatR;
using Todos.Request.Query;
using Todos.Services;

namespace Todos.Handlers.Query;

internal sealed class TodosQueryHandler : IRequestHandler<TodosQuery, Models.Todos[]>
{
    public Task<Models.Todos[]> Handle(TodosQuery request, CancellationToken cancellationToken)
        => Task.FromResult(TodoGenerator.GenerateTodos().ToArray());
}
using Endpoints.Todo.Models;
using Endpoints.Todo.Request.Query;
using Endpoints.Todo.Services;
using MediatR;

namespace Endpoints.Todo.Handlers.Query;

internal sealed class TodosQueryHandler : IRequestHandler<TodosQuery, Todos[]>
{
    public Task<Todos[]> Handle(TodosQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(TodoGenerator.GenerateTodos().ToArray());
}
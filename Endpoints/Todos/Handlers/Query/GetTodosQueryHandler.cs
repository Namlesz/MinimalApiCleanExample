using Endpoints.Todo.Models;
using Endpoints.Todo.Request.Query;
using Endpoints.Todo.Services;
using MediatR;

namespace Endpoints.Todo.Handlers.Query;

internal sealed class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, Todos?>
{
    public Task<Todos?> Handle(GetTodosQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(
            TodoGenerator
                .GenerateTodos()
                .ToArray()
                .FirstOrDefault(a => a.Id == request.Id)
        );
}
using MediatR;
using Todos.Request.Query;
using Todos.Services;

namespace Todos.Handlers.Query;

internal sealed class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, Models.Todos?>
{
    public Task<Models.Todos?> Handle(GetTodosQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(
            TodoGenerator
                .GenerateTodos()
                .ToArray()
                .FirstOrDefault(a => a.Id == request.Id)
        );
    }
}
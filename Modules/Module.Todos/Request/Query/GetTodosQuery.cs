using MediatR;

namespace Todos.Request.Query;

internal sealed record GetTodosQuery(int Id) : IRequest<Models.Todos?>;
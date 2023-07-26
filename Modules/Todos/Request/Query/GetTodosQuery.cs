using MediatR;

namespace Todos.Request.Query;

public sealed record GetTodosQuery(int Id) : IRequest<Models.Todos?>;
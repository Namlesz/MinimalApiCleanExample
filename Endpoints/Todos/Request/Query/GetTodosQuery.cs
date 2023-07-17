using Endpoints.Todo.Models;
using MediatR;

namespace Endpoints.Todo.Request.Query;

public sealed record GetTodosQuery(int Id) : IRequest<Todos?>;
using MediatR;

namespace Todos.Request.Query;

public sealed record TodosQuery : IRequest<Models.Todos[]>;
using MediatR;

namespace Todos.Request.Query;

internal sealed record TodosQuery : IRequest<Models.Todos[]>;
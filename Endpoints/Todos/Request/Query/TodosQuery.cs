using Endpoints.Todo.Services;
using MediatR;

namespace Endpoints.Todo.Request.Query;

public record TodosQuery : IRequest<Todos[]>;

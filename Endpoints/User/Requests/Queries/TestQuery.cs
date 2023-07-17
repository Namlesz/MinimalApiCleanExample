using MediatR;

namespace Endpoints.User.Requests.Queries;

public sealed record TestQuery : IRequest<string>;

using MediatR;

namespace User.Requests.Queries;

public sealed record TestQuery : IRequest<string>;
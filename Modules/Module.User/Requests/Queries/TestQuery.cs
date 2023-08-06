using MediatR;

namespace Module.User.Requests.Queries;

internal sealed record TestQuery : IRequest<string>;
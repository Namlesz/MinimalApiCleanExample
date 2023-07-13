using MediatR;

namespace Endpoints.User.Requests.Queries;

public record TestQuery : IRequest<string>;

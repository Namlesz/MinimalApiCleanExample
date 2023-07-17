using Endpoints.User.Models;
using MediatR;

namespace Endpoints.User.Requests.Queries;

public sealed record GetAllUsersQuery : IRequest<List<UserDto>>;
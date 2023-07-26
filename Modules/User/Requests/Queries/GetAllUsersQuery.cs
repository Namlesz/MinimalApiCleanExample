using MediatR;
using User.Models;

namespace User.Requests.Queries;

public sealed record GetAllUsersQuery : IRequest<List<UserDto>>;
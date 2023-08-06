using MediatR;
using Module.User.Models;

namespace Module.User.Requests.Queries;

internal sealed record GetAllUsersQuery : IRequest<List<UserDto>>;
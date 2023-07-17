using Endpoints.User.Abstract.Repository;
using Endpoints.User.Models;
using Endpoints.User.Requests.Queries;
using MediatR;

namespace Endpoints.User.Handlers.Queries;

internal sealed class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
{

    private readonly IUserRepository _repository;

    public GetAllUsersHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken) =>
        _repository.GetAllUsers();
}
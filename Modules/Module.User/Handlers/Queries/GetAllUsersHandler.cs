using MediatR;
using Module.User.Abstract.Repository;
using Module.User.Models;
using Module.User.Requests.Queries;

namespace Module.User.Handlers.Queries;

internal sealed class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
{
    private readonly IUserRepository _repository;

    public GetAllUsersHandler(IUserRepository repository)
        => _repository = repository;

    public Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        => _repository.GetAllUsers();
}
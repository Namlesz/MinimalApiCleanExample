using MediatR;
using User.Abstract.Repository;
using User.Models;
using User.Requests.Queries;

namespace User.Handlers.Queries;

internal sealed class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
{

    private readonly IUserRepository _repository;

    public GetAllUsersHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return _repository.GetAllUsers();
    }
}
using Endpoints.User.Models;

namespace Endpoints.User.Abstract.Repository;

internal interface IUserRepository
{
    public Task<List<UserDto>> GetAllUsers();
}
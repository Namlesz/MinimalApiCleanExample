using User.Models;

namespace User.Abstract.Repository;

internal interface IUserRepository
{
    public Task<List<UserDto>> GetAllUsers();
}
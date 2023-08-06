using Module.User.Models;

namespace Module.User.Abstract.Repository;

internal interface IUserRepository
{
    public Task<List<UserDto>> GetAllUsers();
}
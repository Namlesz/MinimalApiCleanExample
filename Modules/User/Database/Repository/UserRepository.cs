using User.Abstract.Repository;
using User.Database.Context;
using User.Models;

namespace User.Database.Repository;

internal class UserRepository : IUserRepository
{
    private readonly UsersContext _context;

    public UserRepository(UsersContext context)
    {
        _context = context;
    }

    public Task<List<UserDto>> GetAllUsers()
    {
        return Task.FromResult(_context.Users.ToList());
    }
}
using Module.User.Abstract.Repository;
using Module.User.Database.Context;
using Module.User.Models;

namespace Module.User.Database.Repository;

internal class UserRepository : IUserRepository
{
    private readonly UsersContext _context;

    public UserRepository(UsersContext context)
        => _context = context;

    public Task<List<UserDto>> GetAllUsers()
        => Task.FromResult(_context.Users.ToList());
}
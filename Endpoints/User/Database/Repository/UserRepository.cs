using Endpoints.User.Abstract.Repository;
using Endpoints.User.Database.Context;
using Endpoints.User.Models;

namespace Endpoints.User.Database.Repository;

internal class UserRepository : IUserRepository
{
    private readonly UsersContext _context;

    public UserRepository(UsersContext context) =>
        _context = context;

    public Task<List<UserDto>> GetAllUsers() =>
        Task.FromResult(_context.Users.ToList());
}
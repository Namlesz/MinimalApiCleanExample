using User.Models;

namespace User.Database.Context;

internal class UsersContext
{
    public IEnumerable<UserDto> Users { get; } = new List<UserDto>
    {
        new()
        {
            Name = "John Doe",
            Email = "test@emial.com",
            Password = "123456",
            Address = "street 1",
            Phone = "1234567890"
        },
        new()
        {
            Name = "Jane Doe",
            Email = "tsts@me.pl",
            Password = "null",
            Address = "Null street",
            Phone = "000012010"
        }
    };
}
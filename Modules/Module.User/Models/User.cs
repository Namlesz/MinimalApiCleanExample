namespace Module.User.Models;

internal class UserDto
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
}
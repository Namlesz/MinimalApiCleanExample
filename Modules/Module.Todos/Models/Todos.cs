namespace Todos.Models;

internal class Todos
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly? DueBy { get; set; }

    public bool IsComplete { get; set; }
}
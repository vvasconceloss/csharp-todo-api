namespace csharp_todo_api.Models;

public enum Status
{
    NotStarted,
    InProgress,
    Finished
}

public class Todo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Status Status { get; set; } = Status.NotStarted;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public int UserId { get; set; }
}

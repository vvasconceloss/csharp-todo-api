namespace csharp_todo_api.DTOs;

public class UserCreateDTO
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ConfirmPassword { get; set; } = string.Empty;
    public string? Username { get; set; }
}

public class UserResponseDTO
{
    public string Email { get; set; } = string.Empty;
    public string? Username { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

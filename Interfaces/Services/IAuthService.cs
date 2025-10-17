using csharp_todo_api.DTOs;

namespace csharp_todo_api.Interfaces.Services;

public interface IAuthService
{
    Task<UserResponseDTO> RegisterAsync(UserCreateDTO userDTO);
    Task<string> LoginAsync(string email, string password);
    Task<UserResponseDTO?> GetByEmailAsync(string email);
}

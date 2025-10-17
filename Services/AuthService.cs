using csharp_todo_api.DTOs;
using csharp_todo_api.Interfaces.Services;

namespace csharp_todo_api.Services;

public class AuthService : IAuthService
{
    public Task<UserResponseDTO> RegisterAsync(UserCreateDTO user)
    {
        throw new NotImplementedException();
    }

    public Task<string> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponseDTO?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
}

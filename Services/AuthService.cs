using csharp_todo_api.DTOs;
using csharp_todo_api.Models;
using csharp_todo_api.Exceptions;
using csharp_todo_api.Repositories;
using csharp_todo_api.Interfaces.Services;

namespace csharp_todo_api.Services;

public class AuthService : IAuthService
{
    private readonly AuthRepository _repo;

    public AuthService(AuthRepository repository)
    {
        _repo = repository;
    }

    public async Task<UserResponseDTO> RegisterAsync(UserCreateDTO userDTO)
    {
        if (await _repo.GetByEmailAsync(userDTO.Email) != null)
            throw new ConflictException("This email address has already been registered.");

        var user = new User
        {
            Email = userDTO.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDTO.Password),
            Username = userDTO.Username,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };

        await _repo.RegisterAsync(user);

        return new UserResponseDTO
        {
            Email = user.Email,
            Username = user.Username,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }

    public Task<string> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public async Task<UserResponseDTO?> GetByEmailAsync(string email)
    {
        var user = await _repo.GetByEmailAsync(email);

        if (user == null)
            throw new NotFoundException("The user was not found.");

        return new UserResponseDTO
        {
            Email = user.Email,
            Username = user.Username,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }
}

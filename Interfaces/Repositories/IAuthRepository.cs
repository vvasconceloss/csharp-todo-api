using csharp_todo_api.Models;

namespace csharp_todo_api.Interfaces.Repositories;

public interface IAuthRepository
{
    Task<User> RegisterAsync(User user, string password);
    Task<string> LoginAsync(string email, string password);
    Task<User?> GetByEmailAsync(string email);
}

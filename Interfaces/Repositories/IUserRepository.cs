using csharp_todo_api.Models;

namespace csharp_todo_api.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByEmailAsync(string email);
}

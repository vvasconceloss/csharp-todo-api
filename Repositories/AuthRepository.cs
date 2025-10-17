using csharp_todo_api.Models;
using csharp_todo_api.Interfaces.Repositories;

namespace csharp_todo_api.Repositories;

public class AuthRepository : IAuthRepository
{
    public Task<User> RegisterAsync(User user, string password)
    {
        throw new NotImplementedException();
    }

    public Task<string> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
}

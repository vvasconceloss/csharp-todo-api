using csharp_todo_api.Models;
using csharp_todo_api.Context;
using csharp_todo_api.Interfaces.Repositories;

namespace csharp_todo_api.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;

    public AuthRepository(AppDbContext context)
    {
        _context = context;
    }

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

using csharp_todo_api.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_todo_api.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public required DbSet<User> Users { get; set; }
    public required DbSet<Todo> Todos { get; set; }
}

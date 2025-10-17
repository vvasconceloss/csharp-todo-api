using FluentValidation;
using csharp_todo_api.DTOs;
using csharp_todo_api.Context;
using csharp_todo_api.Services;
using csharp_todo_api.Middlewares;
using csharp_todo_api.Validations;
using csharp_todo_api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddControllers();
builder.Services.AddScoped<AuthRepository>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<IValidator<UserCreateDTO>, UserCreateDTOValidator>();

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();
app.Run();

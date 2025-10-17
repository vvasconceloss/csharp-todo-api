using csharp_todo_api.DTOs;
using csharp_todo_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_todo_api.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _service;

    public AuthController(AuthService service)
    {
        _service = service;
    }

    [HttpPost]
    [Route("user/register")]
    public async Task<ActionResult<UserResponseDTO>> Register(UserCreateDTO userDTO)
    {
        return Ok(await _service.RegisterAsync(userDTO));
    }

    [HttpGet]
    [Route("user/{email}")]
    public async Task<ActionResult<UserResponseDTO>> GetUserByEmail(string email)
    {
        return Ok(await _service.GetByEmailAsync(email));
    }
}

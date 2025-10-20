using FluentValidation;
using csharp_todo_api.DTOs;
using csharp_todo_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_todo_api.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _service;
    private readonly IValidator<UserCreateDTO> _validator;

    public AuthController(AuthService service, IValidator<UserCreateDTO> validator)
    {
        _service = service;
        _validator = validator;
    }

    [HttpPost]
    [Route("user/register")]
    public async Task<ActionResult<UserResponseDTO>> Register(UserCreateDTO userDTO)
    {
        var validationResult = await _validator.ValidateAsync(userDTO);

        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors.Select(error => new { error.PropertyName, error.ErrorMessage });
            return BadRequest(errors);
        }

        return Ok(await _service.RegisterAsync(userDTO));
    }

    [HttpGet]
    [Route("user/{email}")]
    public async Task<ActionResult<UserResponseDTO>> GetUserByEmail(string email)
    {
        return Ok(await _service.GetByEmailAsync(email));
    }
}

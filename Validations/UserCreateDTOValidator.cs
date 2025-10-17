using FluentValidation;
using csharp_todo_api.DTOs;

namespace csharp_todo_api.Validations;

public class UserCreateDTOValidator : AbstractValidator<UserCreateDTO>
{
    public UserCreateDTOValidator()
    {
        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("The email address is required.")
            .EmailAddress().WithMessage("The email address format is invalid.");

        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(8).WithMessage("Password must have at least 8 characters.")
            .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
            .Matches("[0-9]").WithMessage("Password must contain at least one number.")
            .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");

        RuleFor(user => user.ConfirmPassword)
            .Equal(user => user.Password).WithMessage("Passwords do not match.");
    }
}

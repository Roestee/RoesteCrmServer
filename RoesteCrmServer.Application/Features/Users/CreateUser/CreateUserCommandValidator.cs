using FluentValidation;

namespace RoesteCrmServer.Application.Features.Users.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x=>x.FirstName).NotEmpty().MaximumLength(50);
        RuleFor(x=>x.LastName).NotEmpty().MaximumLength(50);
        RuleFor(x=>x.Username).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x=>x.Password).NotEmpty().MinimumLength(8).MaximumLength(50);
        RuleFor(x=>x.PhoneNumber).MaximumLength(20);
    }
}
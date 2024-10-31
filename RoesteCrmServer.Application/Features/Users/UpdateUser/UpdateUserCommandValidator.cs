using FluentValidation;

namespace RoesteCrmServer.Application.Features.Users.UpdateUser;

public sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x=>x.FirstName).NotEmpty().MaximumLength(50);
        RuleFor(x=>x.LastName).NotEmpty().MaximumLength(50);
        RuleFor(x=>x.Username).NotEmpty().MaximumLength(50);
        RuleFor(x=>x.PhoneNumber).MaximumLength(20);
    }
}
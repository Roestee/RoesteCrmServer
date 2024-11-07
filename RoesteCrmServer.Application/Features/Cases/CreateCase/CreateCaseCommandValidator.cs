using FluentValidation;

namespace RoesteCrmServer.Application.Features.Cases.CreateCase;

public sealed class CreateCaseCommandValidator : AbstractValidator<CreateCaseCommand>
{
    public CreateCaseCommandValidator()
    {
        RuleFor(c=>c.Subject).NotEmpty().MaximumLength(200);
    }
}
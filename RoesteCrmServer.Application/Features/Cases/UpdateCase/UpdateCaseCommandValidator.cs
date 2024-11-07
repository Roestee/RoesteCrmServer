using FluentValidation;

namespace RoesteCrmServer.Application.Features.Cases.UpdateCase;

public class UpdateCaseCommandValidator : AbstractValidator<UpdateCaseCommand>
{
    public UpdateCaseCommandValidator()
    {
        RuleFor(c => c.Subject).NotEmpty().MaximumLength(200);
    }
}
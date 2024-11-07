using FluentValidation;

namespace RoesteCrmServer.Application.Features.Opportunities.UpdateOpportunity;

public sealed class UpdateOpportunityCommandValidator : AbstractValidator<UpdateOpportunityCommand>
{
    public UpdateOpportunityCommandValidator()
    {
        RuleFor(o => o.Name).NotEmpty().MaximumLength(30);
        RuleFor(o => o.Probability).MaximumLength(20);
    }
}
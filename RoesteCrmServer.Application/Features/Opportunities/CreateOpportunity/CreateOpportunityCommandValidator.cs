using FluentValidation;

namespace RoesteCrmServer.Application.Features.Opportunities.CreateOpportunity;

public class CreateOpportunityCommandValidator : AbstractValidator<CreateOpportunityCommand>
{
    public CreateOpportunityCommandValidator()
    {
        RuleFor(o => o.Name).NotEmpty().MaximumLength(30);
        RuleFor(o => o.Probability).MaximumLength(20);
    }
}
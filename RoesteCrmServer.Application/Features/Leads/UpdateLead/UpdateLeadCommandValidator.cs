using FluentValidation;

namespace RoesteCrmServer.Application.Features.Leads.UpdateLead;

public sealed class UpdateLeadCommandValidator : AbstractValidator<UpdateLeadCommand>
{
    public UpdateLeadCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50);
        RuleFor(x => x.LastName).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Email).NotEmpty().EmailAddress().MaximumLength(100);
        RuleFor(x => x.Title).MaximumLength(50);
        RuleFor(x=>x.Phone).MaximumLength(15);
        RuleFor(x=>x.Company).MaximumLength(100);
        RuleFor(x=>x.Website).MaximumLength(150);
    }
}
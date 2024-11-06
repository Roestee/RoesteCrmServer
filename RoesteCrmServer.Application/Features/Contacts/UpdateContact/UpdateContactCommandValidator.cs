using FluentValidation;

namespace RoesteCrmServer.Application.Features.Contacts.UpdateContact;

public sealed class UpdateContactCommandValidator : AbstractValidator<UpdateContactCommand>
{
    public UpdateContactCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty().MaximumLength(50);
        RuleFor(c => c.MiddleName).MaximumLength(50);
        RuleFor(c=>c.LastName).NotEmpty().MaximumLength(50);
        RuleFor(c => c.Email).NotEmpty().EmailAddress().MaximumLength(100);
        RuleFor(c => c.Title).MaximumLength(50);
        RuleFor(c => c.Phone).MaximumLength(15);
        RuleFor(c => c.Website).MaximumLength(150);
        RuleFor(c=>c.Department).MaximumLength(150);
    }
}
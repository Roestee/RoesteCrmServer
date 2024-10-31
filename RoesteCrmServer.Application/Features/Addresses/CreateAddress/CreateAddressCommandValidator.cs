using FluentValidation;

namespace RoesteCrmServer.Application.Features.Addresses.CreateAddress;

public sealed class CreateAddressCommandValidator : AbstractValidator<CreateAddressCommand>
{
    public CreateAddressCommandValidator()
    {
        RuleFor(x => x.Country).MaximumLength(50);
        RuleFor(x => x.State).MaximumLength(50);
        RuleFor(x => x.City).MaximumLength(50);
        RuleFor(x => x.Street).MaximumLength(50);
        RuleFor(x => x.PostalCode).MaximumLength(50);
    }
}
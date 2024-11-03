﻿using FluentValidation;

namespace RoesteCrmServer.Application.Features.Accounts.CreateAccount;

public sealed class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
{
    public CreateAccountCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        RuleFor(x=>x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Phone).MaximumLength(15);
        RuleFor(x=>x.Website).MaximumLength(150);
    }
}
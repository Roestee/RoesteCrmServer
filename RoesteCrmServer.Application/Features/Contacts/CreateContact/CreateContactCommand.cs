using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Contacts.CreateContact;

public sealed record CreateContactCommand(
    string FirstName,
    string? MiddleName,
    string LastName,
    string? Title,
    string Email,
    string? Phone,
    string? Description,
    string? Department,
    string? Website,
    Address MailingAddress,
    Address? OtherAddress,
    Guid LeadSourceId,
    Guid SalutationId,
    Guid AccountId,
    Guid ContactOwnerId,
    Guid CreatedById,
    Guid ModifiedById): IRequest<Result<Contact>>;
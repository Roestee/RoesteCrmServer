using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Leads.UpdateLead;

public sealed record UpdateLeadCommand(
    Guid Id,
    string FirstName,
    string LastName,
    string Title,
    string Company,
    string Email,
    string Phone,
    string Description,
    string Website,
    Address Address,
    Guid LeadOwnerId,
    Guid LeadStatusId,
    Guid LeadSourceId,
    Guid SalutationId,
    Guid RatingId,
    Guid IndustryId,
    Guid ModifiedByUserId): IRequest<Result<Lead>>;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Leads.CreateLead;

public sealed record CreateLeadCommand(
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
    Guid IndustryId,
    Guid RatingId,
    Guid ModifiedByUserId,
    Guid CreatedByUserId): IRequest<Result<Lead>>;
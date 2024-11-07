using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Cases.UpdateCase;

public sealed record UpdateCaseCommand(
    Guid Id,
    string Subject,
    string Description,
    Guid CaseStatusId,
    Guid CaseOriginId,
    Guid PriorityId,
    Guid CaseOwnerId,
    Guid? ContactId,
    Guid? AccountId,
    Guid ModifiedById): IRequest<Result<Case>>;
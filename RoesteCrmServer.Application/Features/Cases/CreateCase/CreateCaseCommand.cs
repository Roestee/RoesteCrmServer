using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Cases.CreateCase;

public sealed record CreateCaseCommand(
    string Subject,
    string Description,
    Guid CaseStatusId,
    Guid CaseOriginId,
    Guid PriorityId,
    Guid CaseOwnerId,
    Guid? ContactId,
    Guid? AccountId,
    Guid CreatedById,
    Guid ModifiedById): IRequest<Result<Case>>;
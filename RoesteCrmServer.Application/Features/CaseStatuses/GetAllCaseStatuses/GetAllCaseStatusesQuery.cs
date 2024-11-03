using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.CaseStatuses.GetAllCaseStatuses;

public sealed record GetAllCaseStatusesQuery: IRequest<Result<List<CaseStatus>>>;
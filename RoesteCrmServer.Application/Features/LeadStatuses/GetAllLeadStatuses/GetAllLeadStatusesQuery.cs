using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.LeadStatuses.GetAllLeadStatuses;

public sealed record GetAllLeadStatusesQuery: IRequest<Result<List<LeadStatus>>>;
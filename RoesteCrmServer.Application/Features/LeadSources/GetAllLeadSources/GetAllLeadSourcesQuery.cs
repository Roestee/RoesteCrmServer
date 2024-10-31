using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.LeadSources.GetAllLeadSources;

public sealed record GetAllLeadSourcesQuery: IRequest<Result<List<LeadSource>>>;
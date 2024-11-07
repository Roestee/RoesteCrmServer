using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Opportunities.GetAllOpportunities;

public sealed record GetAllOpportunitiesQuery : IRequest<Result<List<Opportunity>>>;
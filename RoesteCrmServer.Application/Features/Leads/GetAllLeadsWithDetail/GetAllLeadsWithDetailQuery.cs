using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Leads.GetAllLeadsWithDetail;

public sealed record GetAllLeadsWithDetailQuery: IRequest<Result<List<Lead>>>;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Leads.GetLeadByIdWithDetail;

public sealed record GetLeadByIdWithDetailQuery(Guid Id): IRequest<Result<Lead>>;
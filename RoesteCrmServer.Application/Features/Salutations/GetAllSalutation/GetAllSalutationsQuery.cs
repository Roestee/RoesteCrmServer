using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Salutations.GetAllSalutation;

public sealed record GetAllSalutationsQuery: IRequest<Result<List<Salutation>>>;
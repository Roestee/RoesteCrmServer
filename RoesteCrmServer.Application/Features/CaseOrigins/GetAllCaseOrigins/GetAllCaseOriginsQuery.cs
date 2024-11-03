using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.CaseOrigins.GetAllCaseOrigins;

public sealed record GetAllCaseOriginsQuery: IRequest<Result<List<CaseOrigin>>>;
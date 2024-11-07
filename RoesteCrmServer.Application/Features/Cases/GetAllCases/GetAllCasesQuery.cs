using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Cases.GetAllCases;

public sealed record GetAllCasesQuery: IRequest<Result<List<Case>>>;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Industries.GetAllIndustries;

public sealed record GetAllIndustriesQuery: IRequest<Result<List<Industry>>>;
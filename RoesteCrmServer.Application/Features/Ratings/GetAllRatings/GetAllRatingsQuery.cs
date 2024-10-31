using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Ratings.GetAllRatings;

public sealed record GetAllRatingsQuery: IRequest<Result<List<Rating>>>;
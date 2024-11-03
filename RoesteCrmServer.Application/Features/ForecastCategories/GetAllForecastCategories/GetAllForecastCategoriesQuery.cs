using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.ForecastCategories.GetAllForecastCategories;

public sealed record GetAllForecastCategoriesQuery: IRequest<Result<List<ForecastCategory>>>;
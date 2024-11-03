using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.ForecastCategories.GetAllForecastCategories;

internal sealed class GetAllForecastCategoriesQueryHandler(
    IForecastCategoryRepository forecastCategoryRepository): IRequestHandler<GetAllForecastCategoriesQuery, Result<List<ForecastCategory>>>
{
    public async Task<Result<List<ForecastCategory>>> Handle(GetAllForecastCategoriesQuery request, CancellationToken cancellationToken)
    {
        var forecastCategories = await forecastCategoryRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        return forecastCategories;
    }
}
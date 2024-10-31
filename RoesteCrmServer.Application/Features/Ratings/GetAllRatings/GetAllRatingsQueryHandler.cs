using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Ratings.GetAllRatings;

internal sealed class GetAllRatingsQueryHandler(
    IRatingRepository ratingRepository) : IRequestHandler<GetAllRatingsQuery, Result<List<Rating>>>
{
    public async Task<Result<List<Rating>>> Handle(GetAllRatingsQuery request, CancellationToken cancellationToken)
    {
        var ratings = await ratingRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        return ratings;
    }
}
using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Industries.GetAllIndustries;

internal sealed class GetAllIndustriesQueryHandler(
    IIndustryRepository industryRepository): IRequestHandler<GetAllIndustriesQuery, Result<List<Industry>>>
{
    public async Task<Result<List<Industry>>> Handle(GetAllIndustriesQuery request, CancellationToken cancellationToken)
    {
        var industries = await industryRepository
            .GetAll()
            .ToListAsync(cancellationToken);
        
        return industries;
    }
}
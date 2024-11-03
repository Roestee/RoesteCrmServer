using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Stages.GetAllStages;

internal sealed class GetAllStagesQueryHandler(
    IStageRepository stageRepository): IRequestHandler<GetAllStagesQuery, Result<List<Stage>>>
{
    public async Task<Result<List<Stage>>> Handle(GetAllStagesQuery request, CancellationToken cancellationToken)
    {
        var stages = await stageRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        return stages;
    }
}
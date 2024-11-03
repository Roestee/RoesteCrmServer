using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Priorities.GetAllPriorities;

internal sealed class GetAllPrioritiesQueryHandler(
    IPriorityRepository priorityRepository): IRequestHandler<GetAllPrioritiesQuery, Result<List<Priority>>>
{
    public async Task<Result<List<Priority>>> Handle(GetAllPrioritiesQuery request, CancellationToken cancellationToken)
    {
        var priorities = await priorityRepository
            .GetAll()
            .ToListAsync(cancellationToken);
        return priorities;
    }
}
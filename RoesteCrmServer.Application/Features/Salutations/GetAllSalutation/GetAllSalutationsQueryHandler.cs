using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Salutations.GetAllSalutation;

internal sealed class GetAllSalutationsQueryHandler(
    ISalutationRepository salutationRepository): IRequestHandler<GetAllSalutationsQuery, Result<List<Salutation>>>
{
    public async Task<Result<List<Salutation>>> Handle(GetAllSalutationsQuery request, CancellationToken cancellationToken)
    {
        var salutations = await salutationRepository
            .GetAll()
            .ToListAsync(cancellationToken);
        return salutations;
    }
}
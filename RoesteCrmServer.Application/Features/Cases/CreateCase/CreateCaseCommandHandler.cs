using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Cases.CreateCase;

internal sealed class CreateCaseCommandHandler(
    ICaseRepository caseRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper): IRequestHandler<CreateCaseCommand, Result<Case>>
{
    public async Task<Result<Case>> Handle(CreateCaseCommand request, CancellationToken cancellationToken)
    {
        var @case = mapper.Map<Case>(request);
        await caseRepository.AddAsync(@case, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Case>.Succeed(@case, "Dosya başarıyla oluşturuldu.");
    }
}
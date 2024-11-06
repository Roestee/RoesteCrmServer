using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Contacts.CreateContact;

internal sealed class CreateContactCommandHandler(
    IContactRepository contactRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork): IRequestHandler<CreateContactCommand, Result<Contact>>
{
    public async Task<Result<Contact>> Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        var emailExist = await contactRepository.AnyAsync(c=>c.Email == request.Email, cancellationToken);
        if(emailExist)
            return Result<Contact>.Failure("Email daha önce kaydedilmiş!");
            
        var contact = mapper.Map<Contact>(request);
        await contactRepository.AddAsync(contact, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Contact>.Succeed(contact, "İrtibat başarıyla eklendi.");
    }
}
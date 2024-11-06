using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Contacts.DeleteContactById;

internal sealed class DeleteContactByIdCommandHandler(
    IContactRepository contactRepository,
    IUnitOfWork unitOfWork): IRequestHandler<DeleteContactByIdCommand, Result<Contact>>
{
    public async Task<Result<Contact>> Handle(DeleteContactByIdCommand request, CancellationToken cancellationToken)
    {
        var contact = await contactRepository
            .Where(c => c.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (contact is null)
            return Result<Contact>.Failure("İrtibat bulunamadı!");
        
        contactRepository.Delete(contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Contact>.Succeed(contact, "İrtibat başarıyla silindi.");
    }
}
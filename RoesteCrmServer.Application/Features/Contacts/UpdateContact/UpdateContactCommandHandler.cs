using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Contacts.UpdateContact;

internal sealed class UpdateContactCommandHandler(
    IContactRepository contactRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork) : IRequestHandler<UpdateContactCommand, Result<Contact>>
{
    public async Task<Result<Contact>> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        var emailExist =
            await contactRepository.AnyAsync(c => c.Id != request.Id && c.Email == request.Email, cancellationToken);
        if (emailExist)
            return Result<Contact>.Failure("İrtibat içi bu email daha önce kullanılmış!");

        var contact = await contactRepository
            .WhereWithTracking(c => c.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        
        mapper.Map(request, contact);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var updatedContact = await contactRepository
            .Where(c => c.Id == request.Id)
            .Include(c=>c.MailingAddress)
            .Include(c=>c.OtherAddress)
            .Include(c=>c.Salutation)
            .Include(c=>c.ContactOwner)
            .Include(c=>c.CreatedBy)
            .Include(c=>c.ModifiedBy)
            .Include(c=>c.LeadSource)
            .Include(c=>c.Account)
            .FirstOrDefaultAsync(cancellationToken);

        return Result<Contact>.Succeed(updatedContact, "İrtibat başarıyla eklendi.");
    }
}
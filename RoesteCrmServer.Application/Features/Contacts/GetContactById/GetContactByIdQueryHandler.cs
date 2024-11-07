using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Contacts.GetContactById;

internal sealed class GetContactByIdQueryHandler(
    IContactRepository contactRepository): IRequestHandler<GetContactByIdQuery, Result<Contact>>
{
    public async Task<Result<Contact>> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
    {
        var contact = await contactRepository
            .Where(c => c.Id == request.Id)
            .Include(c=>c.MailingAddress)
            .Include(c=>c.OtherAddress)
            .Include(c=>c.Salutation)
            .Include(c=>c.ContactOwner)
            .Include(c=>c.CreatedBy)
            .Include(c=>c.ModifiedBy)
            .Include(c=>c.LeadSource)
            .Include(c=>c.Account)
            .Include(a=>a.Files)
            .FirstOrDefaultAsync(cancellationToken);

        return contact ?? Result<Contact>.Failure("İrtibat bulunamadı!");
    }
}
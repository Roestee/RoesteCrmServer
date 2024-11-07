using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Contacts.GetAllContacts;

internal sealed class GetAllContactsQueryHandler(
    IContactRepository contactRepository): IRequestHandler<GetAllContactsQuery, Result<List<Contact>>>
{
    public async Task<Result<List<Contact>>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
    {
        var contacts = await contactRepository
            .GetAll()
            .Include(c=>c.MailingAddress)
            .Include(c=>c.OtherAddress)
            .Include(c=>c.Salutation)
            .Include(c=>c.ContactOwner)
            .Include(c=>c.CreatedBy)
            .Include(c=>c.ModifiedBy)
            .Include(c=>c.LeadSource)
            .Include(c=>c.Account)
            .Include(a=>a.Files)
            .ToListAsync(cancellationToken);
        
        return contacts;
    }
}
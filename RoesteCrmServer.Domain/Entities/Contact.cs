using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public class Contact: Entity
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public string? Title { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string? Description { get; set; }
    public string? Department { get; set; }
    public string? Website { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
    public Guid LeadSourceId { get; set; }
    public Guid SalutationId { get; set; }
    public Guid MailingAddressId { get; set; }
    public Guid? OtherAddressId { get; set; }
    public Guid AccountId { get; set; }
    public Guid ContactOwnerId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid ModifiedById { get; set; }
    
    public LeadSource? LeadSource { get; set; }
    public Salutation? Salutation { get; set; }
    public Address? MailingAddress { get; set; }
    public Address? OtherAddress { get; set; }
    public Account? Account { get; set; }
    public AppUser? ContactOwner { get; set; }
    public AppUser? CreatedBy { get; set; }
    public AppUser? ModifiedBy { get; set; }
    
    public ICollection<File>? Files { get; set; }

    public Contact()
    {
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }
}
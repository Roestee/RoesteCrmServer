using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public class Account: Entity
{
    public string Name { get; set; } = "";
    public string? Website { get; set; }
    public string? Description { get; set; }
    public string Email { get; set; } = "";
    public string? Phone { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
    public Guid IndustryId { get; set; }
    public Guid AccountTypeId { get; set; }
    public Guid? BillingAddressId { get; set; }
    public Guid? ShippingAddressId { get; set; }
    public Guid AccountOwnerId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid ModifiedById { get; set; }
    
    public Industry? Industry { get; set; }
    public AccountType? AccountType { get; set; }
    public Address? BillingAddress { get; set; }
    public Address? ShippingAddress { get; set; }
    public AppUser? AccountOwner { get; set; }
    public AppUser? CreatedBy { get; set; }
    public AppUser? ModifiedBy { get; set; }
    
    public ICollection<Contact>? Contacts { get; set; }
    public ICollection<Opportunity>? Opportunities { get; set; }
}
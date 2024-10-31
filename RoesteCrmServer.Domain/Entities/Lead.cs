using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public sealed class Lead: Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Title { get; set; }
    public string? Company { get; set; }
    public string? Phone { get; set; }
    public string Email { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedByUserId { get; set; }
    public Guid ModifiedByUserId { get; set; }
    public AppUser? CreatedBy { get; set; }
    public AppUser? ModifiedBy { get; set; }
    public Guid LeadStatusId { get; set; }
    public LeadStatus? LeadStatus { get; set; }
    public Guid RatingId { get; set; }
    public Rating? Rating { get; set; }
    public Guid? AddressId { get; set; }
    public Address? Address { get; set; }
    public Guid SalutationId { get; set; }
    public Salutation? Salutation { get; set; }
    public Guid LeadOwnerId { get; set; }
    public AppUser? LeadOwner { get; set; }
    public Guid LeadSourceId { get; set; }
    public LeadSource? LeadSource { get; set; }
    public Guid? IndustryId { get; set; }
    public Industry? Industry { get; set; }
    
    public Lead()
    {
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }
}
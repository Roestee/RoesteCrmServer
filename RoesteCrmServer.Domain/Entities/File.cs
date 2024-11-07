using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public sealed class File: Entity
{
    public string Path { get; set; }
    public string Extension { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
    public Guid? LeadId { get; set; }
    public Guid? AccountId { get; set; }
    public Guid? ContactId { get; set; }
    public Guid? OpportunityId { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid? ModifiedById { get; set; }
    
    public Lead? Lead { get; set; }
    public Account? Account { get; set; }
    public Contact? Contact { get; set; }
    public Opportunity? Opportunity { get; set; }
    public AppUser? CreatedBy { get; set; }
    public AppUser? ModifiedBy { get; set; }

    public File()
    {
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }
}
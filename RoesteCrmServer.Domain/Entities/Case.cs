using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public class Case: Entity
{
    public string Subject { get; set; }
    public string Description { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
    public Guid CaseStatusId { get; set; }
    public Guid CaseOriginId { get; set; }
    public Guid PriorityId { get; set; }
    public Guid CaseOwnerId { get; set; }
    public Guid? ContactId { get; set; }
    public Guid? AccountId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid ModifiedById { get; set; }
    
    public CaseStatus? CaseStatus { get; set; }
    public CaseOrigin? CaseOrigin { get; set; }
    public Priority? Priority { get; set; }
    public AppUser? CaseOwner { get; set; }
    public Contact? Contact { get; set; }
    public Account? Account { get; set; }
    public AppUser? CreatedBy { get; set; }
    public AppUser? ModifiedBy { get; set; }
}
using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public class Opportunity: Entity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Probability { get; set; }
    public decimal? Amount { get; set; }

    public DateTime CloseDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
    public Guid OpportunityOwnerId { get; set; }
    public Guid AccountId { get; set; }
    public Guid StageId { get; set; }
    public Guid ForecastCategoryId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid ModifiedById { get; set; }

    public AppUser? OpportunityOwner { get; set; }
    public Account? Account { get; set; }
    public Stage? Stage { get; set; }
    public ForecastCategory? ForecastCategory { get; set; }
    public AppUser? CreatedBy { get; set; }
    public AppUser? ModifiedBy { get; set; }
}
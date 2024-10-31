using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public sealed class LeadStatus: Entity
{
    public string Name { get; set; }
}
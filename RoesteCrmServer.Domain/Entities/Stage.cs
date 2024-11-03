using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public sealed class Stage: Entity
{
    public string Name { get; set; }
}
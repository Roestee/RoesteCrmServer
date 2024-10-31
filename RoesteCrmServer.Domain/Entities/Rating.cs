using RoesteCrmServer.Domain.Abstract;

namespace RoesteCrmServer.Domain.Entities;

public sealed class Rating: Entity
{
    public string Name { get; set; }
}
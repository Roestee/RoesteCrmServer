using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Contacts.GetContactById;

public sealed record GetContactByIdQuery(Guid Id): IRequest<Result<Contact>>;
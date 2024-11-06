using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Contacts.DeleteContactById;

public sealed record DeleteContactByIdCommand(Guid Id): IRequest<Result<Contact>>;
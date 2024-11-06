using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Contacts.GetAllContacts;

public sealed record GetAllContactsQuery: IRequest<Result<List<Contact>>>;
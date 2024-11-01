using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Leads.DeleteLeadById;

public sealed record DeleteLeadByIdCommand(Guid Id): IRequest<Result<Lead>>;
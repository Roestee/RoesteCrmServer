using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Leads.DeleteLeadById;

public sealed record DeleteLeadByIdCommand(Guid Id): IRequest<Result<string>>;
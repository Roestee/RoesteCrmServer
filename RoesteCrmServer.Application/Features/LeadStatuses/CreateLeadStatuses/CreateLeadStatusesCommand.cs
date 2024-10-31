using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.LeadStatuses.CreateLeadStatuses;

public sealed record CreateLeadStatusesCommand(string Name): IRequest<Result<string>>;
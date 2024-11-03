using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Stages.GetAllStages;

public sealed record GetAllStagesQuery: IRequest<Result<List<Stage>>>;
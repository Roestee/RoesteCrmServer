using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.LeadStatuses.GetAllLeadStatuses;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin, Manager, User")]
public class LeadStatusesController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery]GetAllLeadStatusesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
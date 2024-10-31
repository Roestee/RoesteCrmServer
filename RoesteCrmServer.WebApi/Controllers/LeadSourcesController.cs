using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.LeadSources.GetAllLeadSources;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

public class LeadSourcesController: ApiController
{
    public LeadSourcesController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery]GetAllLeadSourcesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
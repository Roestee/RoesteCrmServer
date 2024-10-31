using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Industries.GetAllIndustries;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

public class IndustriesController: ApiController
{
    public IndustriesController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery]GetAllIndustriesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
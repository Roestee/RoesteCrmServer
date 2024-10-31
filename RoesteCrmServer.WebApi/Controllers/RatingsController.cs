using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Ratings.GetAllRatings;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

public class RatingsController: ApiController
{
    public RatingsController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery]GetAllRatingsQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
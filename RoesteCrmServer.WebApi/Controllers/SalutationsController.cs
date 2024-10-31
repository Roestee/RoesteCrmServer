using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Salutations.GetAllSalutation;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

public class SalutationsController: ApiController
{
    public SalutationsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery]GetAllSalutationsQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
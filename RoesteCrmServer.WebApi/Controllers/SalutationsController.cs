using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Salutations.GetAllSalutation;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin, Manager, User")]
public class SalutationsController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery]GetAllSalutationsQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
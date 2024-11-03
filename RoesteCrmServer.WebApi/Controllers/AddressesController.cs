using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Addresses.CreateAddress;
using RoesteCrmServer.Application.Features.Addresses.DeleteAddressById;
using RoesteCrmServer.Application.Features.Addresses.GetAllAddresses;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin, Manager, User")]
public class AddressesController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery]GetAllAddressesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpPost]
    public async Task<ActionResult> Create(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteById(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new DeleteAddressByIdCommand(id), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
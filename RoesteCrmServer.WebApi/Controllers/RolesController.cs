using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Roles.CreateRole;
using RoesteCrmServer.Application.Features.Roles.DeleteRoleById;
using RoesteCrmServer.Application.Features.Roles.GetAllRoles;
using RoesteCrmServer.Application.Features.Roles.UpdateRole;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin")]
public class RolesController : ApiController
{
    public RolesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery]GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DeleteRoleByIdCommand(id), cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return StatusCode(result.StatusCode, result);
    }
}
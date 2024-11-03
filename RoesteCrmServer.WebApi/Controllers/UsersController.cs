using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Users.CreateUser;
using RoesteCrmServer.Application.Features.Users.DeleteUserByEmail;
using RoesteCrmServer.Application.Features.Users.DeleteUserById;
using RoesteCrmServer.Application.Features.Users.GetAllUser;
using RoesteCrmServer.Application.Features.Users.GetAllUsersWithRoles;
using RoesteCrmServer.Application.Features.Users.UpdateUser;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin, Manager")]
public class UsersController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery]GetAllUserQuery query, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(query, cancellationToken);
        return StatusCode(response.StatusCode, response);
    } 
    
    [HttpGet]
    public async Task<IActionResult> GetAllWithRoles([FromQuery]GetAllUsersWithRolesQuery query, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(query, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    } 
    
    [HttpDelete("{email}")]
    public async Task<IActionResult> DeleteByEmail(string email, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new DeleteUserByEmailCommand(email), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new DeleteUserByIdCommand(id), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
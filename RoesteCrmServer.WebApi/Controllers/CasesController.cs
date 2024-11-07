using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Cases.CreateCase;
using RoesteCrmServer.Application.Features.Cases.DeleteCaseById;
using RoesteCrmServer.Application.Features.Cases.GetAllCases;
using RoesteCrmServer.Application.Features.Cases.GetCaseById;
using RoesteCrmServer.Application.Features.Cases.UpdateCase;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin, Manager, User")]
public class CasesController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GetAllCasesQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetCaseByIdQuery(id), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new DeleteCaseByIdCommand(id), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateCaseCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(UpdateCaseCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
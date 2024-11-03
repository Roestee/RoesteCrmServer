using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoesteCrmServer.Application.Features.Leads.CreateLead;
using RoesteCrmServer.Application.Features.Leads.DeleteLeadById;
using RoesteCrmServer.Application.Features.Leads.GetAllLeadsWithDetail;
using RoesteCrmServer.Application.Features.Leads.GetLeadByIdWithDetail;
using RoesteCrmServer.Application.Features.Leads.UpdateLead;
using RoesteCrmServer.WebApi.Abstractions;

namespace RoesteCrmServer.WebApi.Controllers;

[Authorize(Roles = "Admin, Manager, User")]
public class LeadsController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    public async Task<IActionResult> GetAllWithDetail([FromQuery]GetAllLeadsWithDetailQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetByIdWithDetail(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetLeadByIdWithDetailQuery(id), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CreateLeadCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteById(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new DeleteLeadByIdCommand(id), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(UpdateLeadCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
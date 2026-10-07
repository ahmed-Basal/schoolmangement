using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Api.Bases;
using SchoolManagement.Core.Feature.Students.command.Models;
using SchoolManagement.Core.Feature.Students.Queries.Models;

namespace SchoolManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(IMediator mediator) : AppControllerBase
{
    [HttpGet("List")]
    public async Task<IActionResult> GetStudentList(CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new GetListQuery(), cancellationToken);
        return NewResult(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudentById([FromRoute] int id, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new GetStudentByIDQuery(id), cancellationToken);
        return NewResult(response);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] AddStudentCommand command, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(command, cancellationToken);
        return NewResult(response);
    }

    [HttpPut("Edit")]
    public async Task<IActionResult> Edit([FromBody] EditStudentCommand command, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(command, cancellationToken);
        return NewResult(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new DeleteStudentCommand(id), cancellationToken);
        return NewResult(response);
    }
}

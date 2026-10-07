using AutoMapper;
using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.command.Models;
using SchoolManagement.Service.Abstract;

namespace SchoolManagement.Core.Feature.Students.command.Handler;

public class EditStudentCommandHandler(IStudentServices studentServices, IMapper mapper) 
    : ResponseHandler, IRequestHandler<EditStudentCommand, Response<string>>
{
    public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
    {
        var student = await studentServices.GetStudentByIdAsync(request.StudID, cancellationToken);
        if (student == null) return NotFound<string>("Student Not Found");

        mapper.Map(request, student);
        var result = await studentServices.UpdateStudentAsync(student, cancellationToken);
        if (result) return Success("Updated Successfully");
        return BadRequest<string>("Failed to update student");
    }
}

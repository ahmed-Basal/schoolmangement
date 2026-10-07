using AutoMapper;
using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.command.Models;
using SchoolManagement.Data.Entities;
using SchoolManagement.Service.Abstract;

namespace SchoolManagement.Core.Feature.Students.command.Handler;

public class AddStudentCommandHandler(IStudentServices studentServices, IMapper mapper) 
    : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
{
    public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var student = mapper.Map<Student>(request);
        var result = await studentServices.AddStudentAsync(student, cancellationToken);
        if (result) return Created("Added Successfully");
        return BadRequest<string>("Failed to add student");
    }
}

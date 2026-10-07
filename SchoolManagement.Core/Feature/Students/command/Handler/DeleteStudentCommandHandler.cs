using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.command.Models;
using SchoolManagement.Service.Abstract;

namespace SchoolManagement.Core.Feature.Students.command.Handler;

public class DeleteStudentCommandHandler(IStudentServices studentServices) 
    : ResponseHandler, IRequestHandler<DeleteStudentCommand, Response<string>>
{
    public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        var result = await studentServices.DeleteStudentAsync(request.Id, cancellationToken);
        if (result) return Deleted<string>("Deleted Successfully");
        return NotFound<string>("Student Not Found");
    }
}

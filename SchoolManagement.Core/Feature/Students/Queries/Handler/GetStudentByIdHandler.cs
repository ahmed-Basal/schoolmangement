using AutoMapper;
using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.Queries.Models;
using SchoolManagement.Core.Feature.Students.Queries.Results;
using SchoolManagement.Service.Abstract;

namespace SchoolManagement.Core.Feature.Students.Queries.Handler;

public class GetStudentByIdHandler(IStudentServices studentServices, IMapper mapper) 
    : ResponseHandler, IRequestHandler<GetStudentByIDQuery, Response<GetSingleStudentResponse>>
{
    public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
    {
        var student = await studentServices.GetStudentByIdAsync(request.Id, cancellationToken);
        if (student == null) return NotFound<GetSingleStudentResponse>("Student Not Found");
        var result = mapper.Map<GetSingleStudentResponse>(student);
        return Success(result);
    }
}

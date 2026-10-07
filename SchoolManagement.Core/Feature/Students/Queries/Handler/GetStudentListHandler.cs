using AutoMapper;
using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.Queries.Models;
using SchoolManagement.Core.Feature.Students.Queries.Results;
using SchoolManagement.Service.Abstract;

namespace SchoolManagement.Core.Feature.Students.Queries.Handler;

public class GetStudentListHandler(IStudentServices studentServices, IMapper mapper) 
    : ResponseHandler, IRequestHandler<GetListQuery, Response<List<GetStudentListResponse>>>
{
    public async Task<Response<List<GetStudentListResponse>>> Handle(GetListQuery request, CancellationToken cancellationToken)
    {
        var studentList = await studentServices.GetAllStudentsAsync(cancellationToken);
        var studentListMapper = mapper.Map<List<GetStudentListResponse>>(studentList);
        return Success(studentListMapper);
    }
}

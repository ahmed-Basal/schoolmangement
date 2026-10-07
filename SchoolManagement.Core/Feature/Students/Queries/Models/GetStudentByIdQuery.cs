using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.Queries.Results;

namespace SchoolManagement.Core.Feature.Students.Queries.Models;

public class GetStudentByIdQuery(int id) : IRequest<Response<GetSingleStudentResponse>>
{
    public int Id { get; set; } = id;
}

public class GetStudentByIDQuery(int id) : GetStudentByIdQuery(id)
{
}

using MediatR;
using SchoolManagement.Core.Bases;
using SchoolManagement.Core.Feature.Students.Queries.Results;

namespace SchoolManagement.Core.Feature.Students.Queries.Models;

public class GetListQuery : IRequest<Response<List<GetStudentListResponse>>>
{
}

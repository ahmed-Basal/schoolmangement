using MediatR;
using SchoolManagement.Core.Bases;

namespace SchoolManagement.Core.Feature.Students.command.Models;

public class DeleteStudentCommand(int id) : IRequest<Response<string>>
{
    public int Id { get; set; } = id;
}

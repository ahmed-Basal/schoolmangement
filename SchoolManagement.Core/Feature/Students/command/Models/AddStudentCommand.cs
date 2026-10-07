using MediatR;
using SchoolManagement.Core.Bases;

namespace SchoolManagement.Core.Feature.Students.command.Models;

public class AddStudentCommand : IRequest<Response<string>>
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public int? DID { get; set; }
}

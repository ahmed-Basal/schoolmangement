using MediatR;
using SchoolManagement.Core.Bases;

namespace SchoolManagement.Core.Feature.Students.command.Models;

public class EditStudentCommand : IRequest<Response<string>>
{
    public int StudID { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public int? DID { get; set; }
}

using SchoolManagement.Core.Feature.Students.command.Models;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Core.Mapping.Students;

public partial class StudentProfile
{
    public void AddStudentCommandMapping()
    {
        CreateMap<AddStudentCommand, Student>();
    }
}

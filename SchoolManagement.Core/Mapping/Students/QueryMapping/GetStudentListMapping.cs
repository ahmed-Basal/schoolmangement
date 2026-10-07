using SchoolManagement.Core.Feature.Students.Queries.Results;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Core.Mapping.Students;

public partial class StudentProfile
{
    public void GetStudentListMapping()
    {
        CreateMap<Student, GetStudentListResponse>()
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department != null ? src.Department.DName : null));
    }
}

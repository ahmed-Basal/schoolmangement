using SchoolManagement.Core.Feature.Students.Queries.Results;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Core.Mapping.Students;

public partial class StudentProfile
{
    public void GetStudentByIDMapping()
    {
        CreateMap<Student, GetSingleStudentResponse>()
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department != null ? src.Department.DName : null))
            .ForMember(dest => dest.Subjects, opt => opt.MapFrom(src => src.StudentSubjects.Select(ss => new SubjectResponse
            {
                SubID = ss.SubID,
                SubjectName = ss.Subject != null ? ss.Subject.SubjectName : null
            })));
    }
}

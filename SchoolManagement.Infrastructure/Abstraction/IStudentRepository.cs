using SchoolManagement.Data.Entities;
using SchoolManagement.Infrastructure.InfrastructureBases;

namespace SchoolManagement.Infrastructure.Abstraction;

public interface IStudentRepository : IGenericRepositoryAsync<Student>
{
    Task<List<Student>> GetStudentsListAsync(CancellationToken cancellationToken = default);
}

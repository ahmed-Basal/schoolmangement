using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data.Entities;
using SchoolManagement.Infrastructure.Abstraction;
using SchoolManagement.Infrastructure.Data;
using SchoolManagement.Infrastructure.InfrastructureBases;

namespace SchoolManagement.Infrastructure.Repo;

public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
{
    #region Fields
    private readonly DbSet<Student> _students;
    #endregion

    #region Constructors
    public StudentRepository(ApplicationDBContext context) : base(context)
    {
        _students = context.Set<Student>();
    }
    #endregion

    #region Handle Functions
    public async Task<List<Student>> GetStudentsListAsync(CancellationToken cancellationToken = default)
    {
        return await _students
            .Include(s => s.Department)
            .Include(s => s.StudentSubjects)
            .ThenInclude(ss => ss.Subject)
            .ToListAsync(cancellationToken);
    }
    #endregion
}

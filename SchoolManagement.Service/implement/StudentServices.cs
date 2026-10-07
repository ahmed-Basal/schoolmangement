using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data.Entities;
using SchoolManagement.Infrastructure.Abstraction;
using SchoolManagement.Service.Abstract;

namespace SchoolManagement.Service.implement;

public class StudentServices(IStudentRepository studentRepository) : IStudentServices
{
    public async Task<bool> AddStudentAsync(Student student, CancellationToken cancellationToken = default)
    {
        await studentRepository.AddAsync(student);
        return true;
    }

    public async Task<bool> DeleteStudentAsync(int id, CancellationToken cancellationToken = default)
    {
        var student = await studentRepository.GetByIdAsync(id);
        if (student == null)
        {
            return false;
        }
        await studentRepository.DeleteAsync(student);
        return true;
    }

    public async Task<List<Student>> GetAllStudentsAsync(CancellationToken cancellationToken = default)
    {
        return await studentRepository.GetStudentsListAsync(cancellationToken);
    }

    public async Task<Student?> GetStudentByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await studentRepository.GetTableNoTracking()
            .Include(x => x.Department)
            .FirstOrDefaultAsync(x => x.StudID == id, cancellationToken);
    }

    public async Task<bool> UpdateStudentAsync(Student student, CancellationToken cancellationToken = default)
    {
        await studentRepository.UpdateAsync(student);
        return true;
    }
}

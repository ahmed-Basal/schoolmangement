using SchoolManagement.Data.Entities;

namespace SchoolManagement.Service.Abstract{

public interface IStudentServices
{
    public Task<List<Student>> GetAllStudentsAsync(CancellationToken cancellationToken = default);
    public Task<Student?> GetStudentByIdAsync(int id, CancellationToken cancellationToken = default);
    public Task<bool> AddStudentAsync(Student student, CancellationToken cancellationToken = default);
    public Task<bool> UpdateStudentAsync(Student student, CancellationToken cancellationToken = default);
    public Task<bool> DeleteStudentAsync(int id, CancellationToken cancellationToken = default);
}


}
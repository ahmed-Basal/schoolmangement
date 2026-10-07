using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Data.Entities
{
    public class Subjects
    {
        public Subjects()
        {
            StudentsSubjects = new HashSet<StudentSubject>();
            DepartmetsSubjects = new HashSet<DepartmetSubject>();
        }

        [Key]
        public int SubID { get; set; }

        [StringLength(500)]
        public string? SubjectName { get; set; }

        public DateTime? Period { get; set; }

        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; }
        public virtual ICollection<DepartmetSubject> DepartmetsSubjects { get; set; }
    }

    // Alias in case referenced as Subject
    public class Subject : Subjects
    {
    }
}

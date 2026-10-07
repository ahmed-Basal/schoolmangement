namespace SchoolManagement.Core.Feature.Students.Queries.Results;

public record GetSingleStudentResponse
{
    public int StudID { get; init; }
    public string? Name { get; init; }
    public string? Address { get; init; }
    public string? Phone { get; init; }
    public string? DepartmentName { get; init; }
    public List<SubjectResponse>? Subjects { get; init; }
}

public record SubjectResponse
{
    public int SubID { get; init; }
    public string? SubjectName { get; init; }
}

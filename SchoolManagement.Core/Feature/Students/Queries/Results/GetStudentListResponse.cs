namespace SchoolManagement.Core.Feature.Students.Queries.Results;

public record GetStudentListResponse
{
    public int StudID { get; init; }
    public string? Name { get; init; }
    public string? Address { get; init; }
    public string? DepartmentName { get; init; }
}

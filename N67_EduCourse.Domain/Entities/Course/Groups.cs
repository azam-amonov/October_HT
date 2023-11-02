namespace N67_EduCourse.Domain.Entities.Course;

public class Groups
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    
    public Guid CourseId { get; set; }
    
    public string Name { get; set; } = default!;
}
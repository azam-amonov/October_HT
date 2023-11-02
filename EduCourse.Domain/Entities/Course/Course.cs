namespace EduCourse.Domain.Entities.Course;

public class Course
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    
    public string Name { get; set; } = default!;
    
    public string Description { get; set; } = default!;
    
    
}
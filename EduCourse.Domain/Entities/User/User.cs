using EduCourse.Domain.Enums;

namespace EduCourse.Domain.Entities.User;

public class User
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = default!;
    
    public string LastName { get; set; } = default!;
    
    public string Email { get; set; } = default!;
    
    public string Password { get; set; } = default!;
    
    public UserRole Role { get; set; }
    
}
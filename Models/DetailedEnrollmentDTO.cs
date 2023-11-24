namespace ApiUniversity.Models;

// Data Transfer Object class, used to bypass navigation properties validation during API calls
public class DetailedEnrollmentDTO
{
    public int Id { get; set; }
    public Grade Grade { get; set; }
    public StudentDTO Student { get; set; } = null!;
    public CourseDTO Course { get; set; } = null!;
    public DetailedEnrollmentDTO() { }

    public DetailedEnrollmentDTO(Enrollment Enrollment)
    {
        Id = Enrollment.Id;
        Grade = Enrollment.Grade;
        Student = Enrollment.StudentDTO;
        Course = Enrollment.CourseDTO;
    }

}
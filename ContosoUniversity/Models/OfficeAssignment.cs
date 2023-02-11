using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models;

public class OfficeAssignment
{
    [Key]
    public int InstructorID { get; set; }

    [Display(Name = "Office Location"), StringLength(50)]
    public string? Location { get; set; }

    public Instructor? Instructor { get; set; }
}

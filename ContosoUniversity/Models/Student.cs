using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required, Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required, Display(Name = "First Name")]
        public string? FirstMidName { get; set;}

        [Display(Name = "Date Enrolled"), DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}

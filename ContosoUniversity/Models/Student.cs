using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required, Display(Name = "Last Name"), StringLength(50)]
        public string? LastName { get; set; }

        [Required, Column("FirstName"), Display(Name = "First Name"), StringLength(50)]
        public string? FirstMidName { get; set;}

        [Display(Name = "Enrollment Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return $"{LastName}, {FirstMidName}"; }
        }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}

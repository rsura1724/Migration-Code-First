using System.ComponentModel.DataAnnotations;

namespace UniversityApplicationPortal.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string CourseName { get; set; }

        public Department Department { get; set; }

        [Required]
        public int DepartmentId { get; set; }

    }
}
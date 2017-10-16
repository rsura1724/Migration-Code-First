using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniversityApplicationPortal.Models;

namespace UniversityApplicationPortal.ViewModels
{
    public class StudentFormViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        [Required]
        public int Department { get; set; }
        
        public IEnumerable<Department> Departments { get; set; }
    }
}
using System.Collections.Generic;
using UniversityApplicationPortal.Models;

namespace UniversityApplicationPortal.ViewModels
{
    public class InstructorFormViewModel
    {
        public string InstructorName { get; set; }
        public string Designation { get; set; }
        public int Department { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
using System.Collections.Generic;
using UniversityApplicationPortal.Models;

namespace UniversityApplicationPortal.ViewModels
{
    public class CourseFormViewModel
    {
        public string CourseName { get; set; }
        public int Department { get; set; }
        public IEnumerable<Department> Departments { get; set; }


    }
}
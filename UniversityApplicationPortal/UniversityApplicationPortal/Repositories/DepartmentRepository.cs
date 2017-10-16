using System.Collections.Generic;
using System.Linq;
using UniversityApplicationPortal.Models;

namespace UniversityApplicationPortal.Repositories
{
    public class DepartmentRepository
    {
        public List<Student> ListOfStudents()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            return context.Students.ToList();
        }


       

        public List<Course> ListOfCourses()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            return context.Courses.ToList();
        }
    }
}
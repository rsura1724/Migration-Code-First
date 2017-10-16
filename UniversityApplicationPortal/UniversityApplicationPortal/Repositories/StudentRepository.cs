using System.Collections.Generic;
using System.Linq;
using UniversityApplicationPortal.Models;

namespace UniversityApplicationPortal.Repositories
{
    public class StudentRepository
    {
        public List<Course> ListOfCourses()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            return context.Courses.ToList();
        }
        public List<Student> ListOfStudents()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            return context.Students.ToList();
        }
        //public Instructor Advisor()
        //{
        //    ManagementContext StudentContext = new ManagementContext();
        //    return StudentContext.Instructors.SingleOrDefault();
        //}
    }
}
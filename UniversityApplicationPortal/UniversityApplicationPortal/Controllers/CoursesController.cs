using System.Linq;
using System.Web.Mvc;
using UniversityApplicationPortal.Models;
using UniversityApplicationPortal.ViewModels;

namespace UniversityApplicationPortal.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult CreateCourse()
        {

            var viewModel = new CourseFormViewModel
            {
                Departments = _context.Departments.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateCourse(CourseFormViewModel viewModel)
        {
            var course = new Course
            {
                CourseName = viewModel.CourseName,
                DepartmentId = viewModel.Department
            };
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
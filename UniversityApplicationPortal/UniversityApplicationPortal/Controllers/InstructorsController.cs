using System.Linq;
using System.Web.Mvc;
using UniversityApplicationPortal.Models;
using UniversityApplicationPortal.ViewModels;

namespace UniversityApplicationPortal.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstructorsController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult CreateInstructor()
        {

            var viewModel = new InstructorFormViewModel
            {
                Departments = _context.Departments.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateInstructor(InstructorFormViewModel viewModel)
        {
            var instructor = new Instructor
            {
                InstructorName = viewModel.InstructorName,
                Designation = viewModel.Designation,
                DepartmentId = viewModel.Department
            };
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
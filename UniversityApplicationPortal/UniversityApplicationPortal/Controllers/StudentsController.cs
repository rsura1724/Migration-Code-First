using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using UniversityApplicationPortal.Models;
using UniversityApplicationPortal.ViewModels;

namespace UniversityApplicationPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        
        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }


        [Authorize]
        public ActionResult Create()
        {
           

            var viewModel = new StudentFormViewModel
            {
              Departments =  _context.Departments.ToList()
            };
            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        public ActionResult Create(StudentFormViewModel viewModel)
        {

            //var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);


            if (!ModelState.IsValid)
            {
                viewModel.Departments = _context.Departments.ToList();
                return View("Create",viewModel);
            }

            var student = new Student
            {
               StudentUserId = User.Identity.GetUserId(),
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                MobileNumber = viewModel.MobileNumber,
                DepartmentId = viewModel.Department,
                

            };
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
    }
}
using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class TeacherController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _teacherCount;

        public TeacherController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _teacherCount = _dbContext.Teachers.Count();
        }

        public IActionResult Index()
        {
            ViewBag.TeacherCount = _teacherCount;

            var teachers = _dbContext.Teachers.Take(4).ToList();

            var viewModel = new TeacherViewModel
            {
                Teachers = teachers,
            };

            return View(viewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var teacher = _dbContext.Teachers.Find(id);

            return View(teacher);
        }


        public IActionResult LoadTeachers(int skip)
        {
            if (skip >= _teacherCount) return BadRequest();
            var teachers = _dbContext.Teachers.Skip(skip).Take(4).ToList();

            return PartialView("_TeacherPartial", teachers);
        }

        public IActionResult Search(string searchedTeacher)
        {
            if (string.IsNullOrWhiteSpace(searchedTeacher)) return NoContent();
             var searchedTeachers = _dbContext.Teachers.Where(x => x.FullName.ToLower().Contains(searchedTeacher.ToLower())).ToList();

            return PartialView("_SearchedTeacherPartial", searchedTeachers);
        }
    }
}

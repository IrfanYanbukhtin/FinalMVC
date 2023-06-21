using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class CourseController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _courseCount;

        public CourseController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _courseCount = _dbContext.Courses.Count();
        }

        public IActionResult Index()
        {
            ViewBag.CourseCount = _courseCount;

            var courses = _dbContext.Courses.Take(3).ToList();

            var viewModel = new CourseViewModel
            {
                Courses = courses,
            };

            return View(viewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var course = _dbContext.Courses.Find(id);

            return View(course);
        }

        public IActionResult LoadCourses(int skipCourse)
        {
        
            var courses = _dbContext.Courses.Skip(skipCourse).Take(3).ToList();

            return PartialView("_CoursePartial", courses);
        }

        public IActionResult Search(string searchedCourse)
        {
            if (string.IsNullOrWhiteSpace(searchedCourse)) return NoContent();
            var courses = _dbContext.Courses.Where(x => x.Title.Contains(searchedCourse)).ToList();

            return PartialView("_SearchedCoursePartial", courses);
        }

    }
}

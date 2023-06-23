using FinalMVC.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Areas.AdminPanel.Controllers
{
	[Area("AdminPanel")]
	public class TeacherController : Controller
	{
		private readonly AppDbContext _dbContext;

		public CourseController(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IActionResult> Index()
		{
			var teachers = await _dbContext.Teachers.ToListAsync();

			return View(teachers);
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			var teacher = await _dbContext.Teachers.FirstOrDefaultAsync(x => x.Id == id);

			if (teacher == null)
				return NotFound();

			return View(teacher);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Course course)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var isExist = await _dbContext.Teachers.AnyAsync(x => x.Title.ToLower().Equals(course.Title.ToLower()));

			if (isExist)
			{
				ModelState.AddModelError("Title", "Allready exists");

				return View();
			}

			await _dbContext.Teachers.AddAsync(teacher);

			await _dbContext.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}
	}
}

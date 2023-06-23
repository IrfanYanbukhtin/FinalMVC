using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Areas.AdminPanel.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

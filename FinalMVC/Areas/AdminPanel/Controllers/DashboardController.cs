using FinalMVC.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _dbContext;
        public DashboardController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

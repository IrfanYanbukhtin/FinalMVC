using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Areas.AdminPanel.Controllers
{
    public class AccountController : Controller
    {
        //private readonly UserManager<AppUser> _userManager;
        //private readonly SignInManager<AppUser> _signInManager;

        //public AccountController(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        public IActionResult Index()
        {
            return View();
        }

      

        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}

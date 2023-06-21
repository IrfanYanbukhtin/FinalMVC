using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public AccountController(UserManager<User> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var user = new User
			{
				UserName = model.Username,
				Email = model.Email,
			};

			var existUsername = await _userManager.FindByNameAsync(model.Username);

			if (existUsername != null)
			{
				ModelState.AddModelError("Username", "Username Required");

				return View();
			}

			var result = await _userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
				await _signInManager.SignInAsync(user, isPersistent: false);

				return RedirectToAction("Index", "Home");
			}

			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError("", item.Description);
				}

				return View();
			}
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var existUser = await _userManager.FindByNameAsync(model.Email);

			if (existUser == null)
			{
				ModelState.AddModelError("", "Email or password is incorrect");

				return View();
			}

			var result = await _signInManager.PasswordSignInAsync(existUser, model.Password, false, false);

			if (!result.Succeeded)
			{
				return View();
			}

			return RedirectToAction("Index", "Home");
		}
	}
}

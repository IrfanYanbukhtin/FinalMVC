using FinalMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalMVC.ViewComponents
{
	public class SubscribeViewComponent : ViewComponent
	{
		public readonly AppDbContext _dbContext;

		public SubscribeViewComponent(AppDbContext appDbContext)
		{
			_dbContext = appDbContext;
		}

		public IViewComponentResult Invoke()
		{
			var subscribe = _dbContext.Subscribes.FirstOrDefault();

			return View(subscribe);
		}
	}
}

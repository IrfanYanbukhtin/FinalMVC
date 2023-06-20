using FinalMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalMVC.ViewComponents
{
    public class HeaderTopViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public HeaderTopViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var topheader = _dbContext.HeaderTop.Include(x => x.TopNavigations).FirstOrDefault();

            return View(topheader);
        }
    }
}

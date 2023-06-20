using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalMVC.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IViewComponentResult Invoke()
        {
            var footer = _dbContext.Footer.Include(x => x.GetInTouch).Include(x => x.Information).Include(x => x.SocialMedia).Include(x => x.UsefulLinks).FirstOrDefault();

            return View(footer);
        }
    }
}

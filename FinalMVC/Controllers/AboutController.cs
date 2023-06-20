using FinalMVC.DAL;
using FinalMVC.DAL.Entities;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _dbContext;
        public AboutController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var about = _dbContext.Abouts.ToList();
            var testimonial = _dbContext.Testimonials.ToList();
            var notices = _dbContext.Notices.ToList();
            var noticeVideos = _dbContext.NoticeVideos.ToList();
            var teachers = _dbContext.Teachers.Take(4).ToList();

            var viewModel = new AboutViewModel
            {
                Abouts = about,
                Testimonials = testimonial,
                Notices = notices,
                NoticesVideo = noticeVideos,
                Teachers = teachers,

            };

            return View(viewModel);
        }
    }
}

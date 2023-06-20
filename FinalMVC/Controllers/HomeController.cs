using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using FinalMVC.DAL;
using FinalMVC.DAL.Entities;

namespace FinalMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var sliderImage = await _dbContext.SliderImages.ToListAsync();
            var notice = await _dbContext.Notices.ToListAsync();
            var noticeInfo = await _dbContext.NoticeInfos.ToListAsync();
            var banner = await _dbContext.Banners.ToListAsync();
            var course = await _dbContext.Courses.ToListAsync();
            var events = await _dbContext.Events.ToListAsync();
            var testimonial = await _dbContext.Testimonials.ToListAsync();
            var blog = await _dbContext.Blogs.ToListAsync();

            var viewModel = new HomeViewModel
            {
                SliderImages = sliderImage,       
                Notices = notice,
                NoticesInfo = noticeInfo,
                Banners = banner,
                Courses = course,
                Events = events,
                Testimonials = testimonial,
                Blogs = blog,

            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
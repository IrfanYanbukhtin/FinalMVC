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

        public IActionResult Index()
        {
            var sliderImage =  _dbContext.SliderImages.ToList();
            var notice =  _dbContext.Notices.ToList();
            var noticeInfo =  _dbContext.NoticeInfos.ToList();
            var banner = _dbContext.Banners.ToList();
            var course =  _dbContext.Courses.Take(3).ToList();
            var events =  _dbContext.Events.Take(3).ToList();
            var testimonial =  _dbContext.Testimonials.ToList();
            var blog =  _dbContext.Blogs.Take(3).ToList();

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
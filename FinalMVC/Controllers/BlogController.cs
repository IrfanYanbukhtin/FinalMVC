using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class BlogController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _blogCount;

        public BlogController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _blogCount = _dbContext.Blogs.Count();
        }
        public IActionResult Index()
        {
            var pageCounts = _dbContext.PageCounts.ToList();

            ViewBag.BlogCount = _blogCount;

            var blogs = _dbContext.Blogs.Take(3).ToList();

            var viewModel = new BlogViewModel
            {
                Blogs = blogs,
                PageCounts = pageCounts
            };

            return View(viewModel);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)return NotFound();

            var blog = _dbContext.Blogs.Find(id);

            return View(blog);
        }

        public IActionResult LoadBlogs(int skipBlog)
        {
      
            var blogs = _dbContext.Blogs.Skip(skipBlog).Take(3).ToList();

            return PartialView("_BlogPartial", blogs);
        }
    }
}

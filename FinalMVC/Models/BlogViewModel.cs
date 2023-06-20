using FinalMVC.DAL.Entities;

namespace FinalMVC.Models
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<PageCount> PageCounts { get; set; }
    }
}

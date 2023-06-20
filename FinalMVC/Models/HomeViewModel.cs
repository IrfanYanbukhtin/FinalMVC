using FinalMVC.DAL.Entities;

namespace FinalMVC.Models
{
    public class HomeViewModel
    {
        public List<SliderImage>? SliderImages { get; set; }
        public List<Notice> Notices { get; set; }
        public List<NoticeInfo> NoticesInfo { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}

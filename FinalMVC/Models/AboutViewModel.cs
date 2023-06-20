using FinalMVC.DAL.Entities;

namespace FinalMVC.Models
{
    public class AboutViewModel
    {
        public List<About>? Abouts { get; set; }
        public List<Testimonial>? Testimonials { get; set; }
        public List<Notice>? Notices { get; set; }
        public List <NoticeVideo>? NoticesVideo { get; set;}
        public List<Teacher>? Teachers { get; set; }
    }
}

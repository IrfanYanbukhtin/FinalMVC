using FinalMVC.DAL.Entities;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace FinalMVC.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<HeaderTop> HeaderTop { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<TopNavigation> TopNavigations { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<GetInTouch> GetInTouch { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<UsefulLinks> UsefulLinks { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<NoticeInfo> NoticeInfos { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<NoticeVideo> NoticeVideos  { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<PageCount> PageCounts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

    }
}

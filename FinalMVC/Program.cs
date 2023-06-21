using System;
using FinalMVC.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinalMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();

            builder.Services.AddControllersWithViews();

            builder.Services.AddSession(option =>
            {
                option.Cookie.Name = "MySession";
                option.IdleTimeout = TimeSpan.FromMinutes(5);
            });

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(builder =>
            {
                builder.UseSqlServer(connectionString);
            });

            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
				options.Password.RequireUppercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);

				options.Password.RequireLowercase = false;
				options.Lockout.MaxFailedAccessAttempts = 3;
				options.User.RequireUniqueEmail = true;

				options.SignIn.RequireConfirmedEmail = false;
				options.Lockout.AllowedForNewUsers = true;

			}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


            var app = builder.Build();

            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "areas",
                        pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

            app.Run();
        }
    }
}
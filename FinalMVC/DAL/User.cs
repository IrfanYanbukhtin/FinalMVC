using Microsoft.AspNetCore.Identity;

namespace FinalMVC.DAL
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
    }
}

using FinalMVC.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalMVC.Models
{
    public class ContactViewModel
    {
        public List<Contact>? Contacts { get; set; }
    }
}

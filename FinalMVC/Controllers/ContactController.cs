using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var contact = _dbContext.Contacts.ToList();

            var viewModel = new ContactViewModel
            {
                Contacts = contact,
            };

            return View(viewModel);
        }
    }
}

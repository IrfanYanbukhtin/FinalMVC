using FinalMVC.DAL;
using FinalMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVC.Controllers
{
    public class EventController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _eventCount;


        public EventController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _eventCount = _dbContext.Events.Count();

        }

        public IActionResult Index()
        {
            ViewBag.EventCount = _eventCount;

            var events = _dbContext.Events.Take(3).ToList();
            var speakers = _dbContext.Speakers.ToList();

            var viewModel = new EventViewModel
            {
                Events = events,
                Speakers = speakers,
            };

            return View(viewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var events = _dbContext.Events.Find(id);

            return View(events);
        }

        public IActionResult LoadEvents(int skipEvent)
        {
            if (skipEvent >= _eventCount) return BadRequest();
            var events = _dbContext.Events.Skip(skipEvent).Take(3).ToList();

            return PartialView("_EventPartial", events);
        }
    }
}

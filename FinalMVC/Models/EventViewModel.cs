using FinalMVC.DAL.Entities;

namespace FinalMVC.Models
{
    public class EventViewModel
    {
        public List<Event> Events { get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}

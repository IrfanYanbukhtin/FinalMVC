namespace FinalMVC.DAL.Entities
{
    public class TopNavigation : Entity
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public int HeaderTopId { get; set; }
        public HeaderTop HeaderTop { get; set; }
    }
}

namespace FinalMVC.DAL.Entities
{
    public class Event : Entity
    {
        public string ImageUrl { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
    }
}

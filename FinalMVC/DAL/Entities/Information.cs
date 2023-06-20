namespace FinalMVC.DAL.Entities
{
    public class Information : Entity
    {
        public string Title { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}

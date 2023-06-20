namespace FinalMVC.DAL.Entities
{
    public class UsefulLinks : Entity
    {
        public string Title { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}

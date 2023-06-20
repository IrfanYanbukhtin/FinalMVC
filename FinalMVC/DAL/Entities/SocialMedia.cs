namespace FinalMVC.DAL.Entities
{
    public class SocialMedia : Entity
    {
        public string SocialM { get; set; }
        public int FooterId { get; set; }
        public Footer Footer { get; set; }
    }
}

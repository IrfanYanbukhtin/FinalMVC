namespace FinalMVC.DAL.Entities
{
    public class Contact : Entity
    {
        public string ContactImgUrl { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

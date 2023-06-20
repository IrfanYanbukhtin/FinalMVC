namespace FinalMVC.DAL.Entities
{
    public class HeaderTop : Entity
    {
        public string Connection { get; set; }
        public ICollection<TopNavigation> TopNavigations { get; set; }
    }
}

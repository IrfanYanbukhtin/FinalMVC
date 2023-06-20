namespace FinalMVC.DAL.Entities
{
    public class Blog : Entity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public string Date { get; set; }
        public int CommentCount { get; set; }
        public string InfoLink { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinalMVC.DAL.Entities
{
    public class Header : Entity
    {
        public string LogoUrl { get; set; }
        public ICollection<Navigation> Navigation { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Karnosh.Models
{
    [Index("Name", IsUnique = true)]
    public class Hero
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }
        public virtual ICollection<Video> ?Video { get; set; }
    }
}

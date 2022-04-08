using Microsoft.EntityFrameworkCore;

namespace Karnosh.Models
{
    [Index("Name", IsUnique = true)]
    public class Video
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Poster { get; set; }
        public String Galary { get; set; }
        public String Traler { get; set; }
        public String otherName { get; set; }
        public String ArabicName { get; set; }
        public String OriginalLink { get; set; }
        public String Description { get; set; }
  
        // now relatins - one to many
        public ICollection<Server> ?Servers { get; set; }
        public Year ?Year { get; set; }
        // relations - many to many
        public Rating ? Rating { get; set; }
        public  Quality ? Quality { get; set; }
        public  ICollection<Generes> ? Generes { get; set; }
        public Duration ? Duration { get; set; }
        public Catagory ? Catagory { get; set; }
        public ICollection<Related> ? Related { get; set; }
        public ICollection<Hero>? Hero { get; set; }


    }
}

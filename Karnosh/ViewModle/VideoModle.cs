namespace Karnosh.ViewModle
{
    public class VideoModle
    {
        public String Name { get; set; }
        public String Poster { get; set; }
        public String Galary { get; set; }
        public String Traler { get; set; }
        public String otherName { get; set; }
        public String ArabicName { get; set; }
        public String OriginalLink { get; set; }
        public String Description { get; set; }
        public String Year { get; set; }
        public String Rating { get; set; }
        public String Quality { get; set; }
        public String Duration { get; set; }
        public String Catagory { get; set; }
        public List<String> Servers { get; set; }
        public List<String> Generess { get; set; }
        public List<String> Related { get; set; }

        public List<HeroView> Hero { get; set; }

    }
    public class HeroView
    {
        public String Name { get; set; }
        public String Image { get; set; }
    }
 
}

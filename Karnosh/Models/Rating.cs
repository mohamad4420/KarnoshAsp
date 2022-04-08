using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karnosh.Models
{
    [Index("Rate", IsUnique = true)]
    public class Rating
    {

        public int Id { get; set; }
        public String Rate { get; set; }
        public virtual ICollection<Video> ?Video { get; set; }

    }
}

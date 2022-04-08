using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karnosh.Models
{
    [Index("Time", IsUnique = true)]
    public class Duration
    {
        public int Id { get; set; }
        public String Time { get; set; }
        public ICollection<Video> ?Video { get; set; }
    }
}

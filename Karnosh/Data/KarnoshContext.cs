#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Karnosh.Models;

namespace Karnosh.Data
{
    public class KarnoshContext : DbContext
    {
        public KarnoshContext (DbContextOptions<KarnoshContext> options)
            : base(options)
        {
        }

        public DbSet<Karnosh.Models.Video> Video { get; set; }
        public DbSet<Karnosh.Models.Year> Year { get; set; }
        public DbSet<Karnosh.Models.Rating> Rating { get; set; }
        public DbSet<Karnosh.Models.Server> Server { get; set; }
        public DbSet<Karnosh.Models.Catagory> Catagory { get; set; }
        public DbSet<Karnosh.Models.Duration> Duration { get; set; }
        public DbSet<Karnosh.Models.Generes> Generes { get; set; }
        public DbSet<Karnosh.Models.Quality> Quality { get; set; }
        public DbSet<Karnosh.Models.Related> Related { get; set; }
        public DbSet<Karnosh.Models.Hero> Hero { get; set; }
    }
}

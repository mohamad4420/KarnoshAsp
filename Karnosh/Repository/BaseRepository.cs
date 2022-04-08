using Karnosh.Data;
using Karnosh.Interface;
using Karnosh.Models;
using Karnosh.ViewModle;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Karnosh.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected KarnoshContext _context;

        public BaseRepository(KarnoshContext context)
        {
                _context = context;
        }
        public Video AddVideoAll(VideoModle videoModle)
        {
            var year = _context.Year.FirstOrDefault(b=>b.Name==videoModle.Year);
            var rating = _context.Rating.FirstOrDefault(r => r.Rate == videoModle.Rating);
            var quality = _context.Quality.FirstOrDefault(q=>q.Name==videoModle.Quality);
            var duration =_context.Duration.FirstOrDefault(d=>d.Time==videoModle.Duration);
            var catagory = _context.Catagory.FirstOrDefault(c=>c.Name==videoModle.Catagory);
            List<Generes>? generes = new ();
            foreach (String item in videoModle.Generess)
            {
                Generes ?gen = _context.Generes.FirstOrDefault(g=>g.Name==item)?? new Generes() { Name = item };
                generes.Add(gen);

            }
            List<Related>? relateds = new();
            foreach (String item in videoModle.Related)
            {
                Related? relt = _context.Related.FirstOrDefault(g => g.Name == item) ?? new Related() { Name = item };
                relateds.Add(relt);
            }
            List<Hero>? heroes = new ();
            foreach (var item in videoModle.Hero)
            {
                Hero? hero = _context.Hero.FirstOrDefault(g => g.Name == item.Name) ?? new Hero() { Name = item.Name,Image=item.Image };
                heroes.Add(hero);
            }
            List<Server>? servers = new();
            foreach (String item in videoModle.Servers)
            {
                servers.Add(new Server() { Name=item});
            }
            var video = new Video()
            {
                Name = videoModle.Name,
                Poster = videoModle.Poster,
                Galary = videoModle.Galary,
                Traler = videoModle.Traler,
                otherName = videoModle.otherName,
                ArabicName = videoModle.ArabicName,
                OriginalLink = videoModle.OriginalLink,
                Description = videoModle.Description,
                Year = year ?? new() { Name = videoModle.Year },
                Rating = (rating ?? new() { Rate = videoModle.Rating }),
                Quality = quality ?? new() { Name = videoModle.Quality },
                Duration = duration ?? new() { Time = videoModle.Duration },
                Catagory = catagory ?? new() { Name = videoModle.Catagory },
                Generes= (ICollection<Generes>)generes,
                Related = (ICollection<Related>)relateds,
                Servers = (ICollection<Server>)servers,
                Hero=(ICollection<Hero>)heroes
            };
            _context.AddRange(video);
            _context.SaveChanges();
          
            return video;
        }
        public void Add(T e)
        {
          _context.Set<T>().Add(e);
          _context.SaveChanges();
        
        }



        public void DeleteById(int id)
        {
            var data = _context.Set<T>().Find(id);
            if (data != null)
            _context.Set<T>().Remove(data);
          
        }

        public void DeleteByName(string name)
        {
            var data = _context.Set<T>().Find(name);
            if (data != null)
                _context.Set<T>().Remove(data);
        }

        public T Find(Expression<Func<T, bool>> match, string[] includes)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
                foreach (string include in includes)
                    query = query.Include(include);

            var result = query.FirstOrDefault(match);
             return null;
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
                foreach (string include in includes)
                    query = query.Include(include);

            var result = query.Where(match);
            return result;
        }
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> ?filter, string[] ?includes, int? Tack, int? Skip, Expression<Func<T, object>> ?orderBy = null, string orderByDirection = "ASC")
        {


            IQueryable<T> query =_context.Set<T>();
            if(filter != null)
            query= query.Where(filter);

            if (Tack.HasValue)
                query.Take(Tack.Value);
            if (Skip.HasValue)
                query.Skip(Skip.Value);
            if (orderBy != null)
            {
                if(orderByDirection ==OrderBy.Descending)
                    query = query.OrderByDescending(orderBy);
                else
                    query = query.OrderBy(orderBy);
            }
            if (includes != null)
                foreach (string include in includes)
                {
                    query = query.Include(include);
                }
            if (query.ToList()!=null)
             return query.ToList();
            else 
                return null;
        }

        public List<T> GetAllData()
        {
            return _context.Set<T>().ToList(); 
        }

   
    }
}

using Karnosh.Models;
using Karnosh.ViewModle;
using System.Linq.Expressions;

namespace Karnosh.Interface
{
    public interface IBaseRepository<T>
    {
        Video AddVideoAll(VideoModle videoModle);
         List<T> GetAllData();
         void Add(T e);
         T Find(Expression<Func<T,bool>> match , string[] includes);
         IEnumerable<T> FindAll(Expression<Func<T, bool>> filter, string[] includes, int ?Tack, int ?Skip,
         Expression<Func<T, object>> ?orderBy=null,string orderByDirection = OrderBy.Ascending);
        void DeleteByName(String name);
         void DeleteById(int id);

    }
}

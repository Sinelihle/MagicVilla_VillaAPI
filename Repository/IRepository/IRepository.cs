using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        //these first two are for LINQ expressions
        //everything is now geeric and can be consumed by other controller's
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, int pageSize = 3, int pageNumber = 1);

        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);

        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);

        Task SaveAsync();
    }
}

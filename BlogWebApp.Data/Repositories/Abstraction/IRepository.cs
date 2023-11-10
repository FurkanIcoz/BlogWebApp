using BlogWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Data.Repositories.Abstraction
{
    public interface IRepository<T> where T : class,IEntityBase,new()
    {
        Task<List<T>> GetAllAsyn(Expression<Func<T,bool>> predicate = null,params Expression<Func<T, object>>[] includeProperties);

        Task AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByGuidAsync(Guid id);
        Task<T> UpdateAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null);
    }
}

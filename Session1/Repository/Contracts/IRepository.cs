using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IRepository<T> where T : TableDbBase
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetByPageAsync(int pageNumber, int pageSize);

        Task<IEnumerable<T>> GetAllAsync();

        Task Create(T entity);

        Task Delete(int id);

        void Delete(T entity);

        Task SaveAsync();
    }
}

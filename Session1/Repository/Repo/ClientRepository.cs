using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Entities;
using System.Linq.Expressions;

namespace Repository.Repo
{
    public class GenericRepository<T> : IRepository<T> where T : TableDbBase
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        { 
            _context = context;
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate) => await _context.Set<T>().FirstOrDefaultAsync(predicate: predicate);
        
        public async Task<IEnumerable<T>> GetByPageAsync(int pageNumber, int pageSize) => await _context.Set<T>().Skip(pageNumber+pageSize-1).Take(pageSize).ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async Task Create(T entity) => await _context.Set<T>().AddAsync(entity);

        public async Task Delete(int id) => Delete(await GetAsync(x => x.Id == id));

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}

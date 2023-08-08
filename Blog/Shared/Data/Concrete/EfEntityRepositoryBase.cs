using Blog.Shared.Data.Abstract;
using Blog.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Blog.Shared.Data.Concrete
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().CountAsync(predicate);
        }

        public Task DeleteAsync(T entity)
        {
            return Task.Run(() => { _context.Set<T>().Remove(entity); });
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach(var property in includeProperties)
                {
                    query = query.Include(property);

                }
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);

                }
            }
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => { _context.Set<T>().Update(entity); });
        }
    }
}

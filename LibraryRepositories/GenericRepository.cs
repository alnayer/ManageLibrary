using LibraryContracts;
using LibraryDAL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryRepositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly LibraryContext _context;

        public GenericRepository(LibraryContext paramContext)
        {
            _context = paramContext;
        }

        public async Task<bool> AddEntity<T>(TEntity entity)
        {
            _context.Add(entity);
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<bool> DeleteEntity<T>(TEntity entity)
        {
            _context.Remove(entity);
            return (await _context.SaveChangesAsync() > 0);
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this._context.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public IQueryable<TEntity> GetAllEntity<T>()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<bool> UpdateEntity<T>(TEntity entity)
        {
            var existing =await _context.Set<TEntity>().FindAsync(entity);
            if (existing != null)
            {
                _context.Entry(entity).CurrentValues.SetValues(entity);
            }
            return (await _context.SaveChangesAsync() > 0);
            
        }
    }
}

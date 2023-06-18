using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryContracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<bool> AddEntity<T>(TEntity entity);       
        public Task<bool> UpdateEntity<T>(TEntity entity);
        public Task<bool> DeleteEntity<T>(TEntity entity);
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);
        public IQueryable<TEntity> GetAllEntity<T>();
    }
}

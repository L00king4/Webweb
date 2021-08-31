using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseRepo<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIDAsync(int id);
        public Task AddAsync(T model);
        public Task AddRangeAsync(IEnumerable<T> models);
        public Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> expression);
        public Task<T> FirstAsync(Expression<Func<T, bool>> expression);
        public Task<T> FindAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseRepo<TModel> where TModel : class
    {
        public Task<IEnumerable<TModel>> GetAllAsync();
        public Task<TModel> GetByIDAsync(int id);
        public Task AddAsync(TModel model);
        public Task AddRangeAsync(IEnumerable<TModel> models);
        public Task<IQueryable<TModel>> WhereAsync(Expression<Func<TModel, bool>> expression);
        public Task<TModel> FirstAsync(Expression<Func<TModel, bool>> expression);
        public Task<TModel> FindAsync(int id);
    }
}

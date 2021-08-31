using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Repos.Base
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected readonly AppDbContext _db;
        public BaseRepo(AppDbContext db) {
            _db = db;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }
        public virtual async Task<T> GetByIDAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }
        public virtual async Task AddAsync(T model) {
            await _db.Set<T>().AddAsync(model);
        }
        public virtual async Task AddRangeAsync(IEnumerable<T> models)
        {
            await _db.Set<T>().AddRangeAsync(models);
        }
        public virtual async Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> expression)
        {
            return await Task.Run(() => _db.Set<T>().Where(expression));
        }
        public virtual async Task<T> FirstAsync(Expression<Func<T, bool>> expression) {
            return await _db.Set<T>().FirstOrDefaultAsync(expression);
        }

        public virtual async Task<T> FindAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }
    }
}

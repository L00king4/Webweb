using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces.Repos.Base;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Repos.Base
{
    public class BaseRepo<TModel> : IBaseRepo<TModel> where TModel : class, IBaseModel
    {
        protected readonly AppDbContext _db;
        public BaseRepo(AppDbContext db)
        {
            _db = db;
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var elements = await _db.Set<TModel>().ToListAsync();
            elements.Reverse();
            return elements;
        }
        public virtual async Task<TModel> GetByIDAsync(int id)
        {
            return await _db.Set<TModel>().FindAsync(id);
        }
        public virtual async Task<TModel> AddAsync(TModel model)
        {
            return (await _db.Set<TModel>().AddAsync(model)).Entity;
        }
        public virtual async Task AddRangeAsync(IEnumerable<TModel> models)
        {
            await _db.Set<TModel>().AddRangeAsync(models);
        }
        public virtual async Task<IQueryable<TModel>> WhereAsync(Expression<Func<TModel, bool>> expression)
        {
            return await Task.Run(() => _db.Set<TModel>().Where(expression));
        }
        public virtual async Task<TModel> FirstAsync(Expression<Func<TModel, bool>> expression)
        {
            return await _db.Set<TModel>().FirstOrDefaultAsync(expression);
        }

        public virtual async Task<TModel> FindAsync(int id)
        {
            return await _db.Set<TModel>().FindAsync(id);
        }

        public virtual async Task RemoveByIDAsync(int id)
        {
            var model = await _db.Set<TModel>().FindAsync(id);
            if (model != null) { _db.Set<TModel>().Remove(model); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces.Repos.Base;
using WebEntities.Enums;

namespace Webweb.Services.Repos.Base
{
    public class BaseEventRepo<TModel> : BaseRepo<TModel>, IBaseEventRepo<TModel> where TModel : BaseEvent
    {
        public BaseEventRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<IEnumerable<TModel>> GetAllByAgeGroupAsync(AgeGroup? ageGroup)
        {
            return ageGroup == null 
                ? await base.GetAllAsync() 
                : _db.Set<TModel>().Where(x => x.AgeGroup == ageGroup).ToList();
        }

        public virtual async Task<bool> AlreadyExistsAsync(BaseEvent model)
        {
            return await GetByModelAsync(model) != null;
        }

        public virtual async Task<TModel> GetByModelAsync(BaseEvent model)
        {
            return await FirstAsync(
                x => x.Name == model.Name && x.ToPay == model.ToPay
            );
        }

        public virtual Task RemoveAsync(BaseEvent model)
        {
            throw new NotImplementedException();
        }

        public virtual Task RemoveRangeAsync(BaseEvent model)
        {
            throw new NotImplementedException();
        }
    }
}

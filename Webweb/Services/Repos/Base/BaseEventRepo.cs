using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Repos.Base
{
    public class BaseEventRepo<T> : BaseRepo<T>, IBaseEventRepo<T> where T : BaseEvent
    {
        public BaseEventRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<bool> AlreadyExistsAsync(BaseEvent model)
        {
            return await GetByModelAsync(model) != null;
        }

        public virtual async Task<T> GetByModelAsync(BaseEvent model)
        {
            return await FirstAsync(
                x => x.Name == model.Name && x.ToPay == model.ToPay && x.Date == model.Date
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

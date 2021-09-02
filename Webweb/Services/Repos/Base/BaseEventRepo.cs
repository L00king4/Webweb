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
    public class BaseEventRepo<T> : BaseRepo<T>, IBaseEventRepo<T> where T : class
    {
        public BaseEventRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<bool> AlreadyExistsAsync(BaseEvent model)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByModelAsync(BaseEvent model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(BaseEvent model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(BaseEvent model)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Repos.Base
{
    public class BaseEventRepo<T> : BaseRepo<T>, IBaseEventRepo<T> where T : class
    {
        public BaseEventRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<bool> AlreadyExistsAsync(IBaseEvent model)
        {
            throw new NotImplementedException();
        }
    }
}

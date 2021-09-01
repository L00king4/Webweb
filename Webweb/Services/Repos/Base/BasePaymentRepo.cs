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
    public class BasePaymentRepo<T> : BaseRepo<T>, IBasePaymentRepo<T> where T : class
    {
        public BasePaymentRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<bool> AlreadyExistsAsync(IBasePayment model)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByModelAsync(IBasePayment model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(IBasePayment model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(IBasePayment model)
        {
            throw new NotImplementedException();
        }
    }
}

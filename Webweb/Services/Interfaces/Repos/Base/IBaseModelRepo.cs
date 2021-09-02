using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseModelRepo<TModel, TBaseModel> : IBaseRepo<TModel> where TModel : class
    {
        public Task<bool> AlreadyExistsAsync(TBaseModel model);
        public Task RemoveAsync(TBaseModel model);
        public Task RemoveRangeAsync(TBaseModel model);
        public Task<TModel> GetByModelAsync(TBaseModel model); 
    }
}

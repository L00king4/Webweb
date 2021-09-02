using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities.Models.BaseModels;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseModelRepo<TIBaseModel> : IBaseRepo<T>
    {
        public Task<bool> AlreadyExistsAsync(TIBaseModel model);
        public Task RemoveAsync(TIBaseModel model);
        public Task RemoveRangeAsync(TIBaseModel model);
        public Task<TIBaseModel> GetByModelAsync(TIBaseModel model); 
    }
}

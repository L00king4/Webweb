using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseModelRepo<T, TIBaseModel> : IBaseRepo<T> where T: class
    {
        public Task<bool> AlreadyExistsAsync(TIBaseModel model);
    }
}

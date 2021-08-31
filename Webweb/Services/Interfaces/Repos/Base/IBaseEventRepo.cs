using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseEventRepo<T> : IBaseModelRepo<T, IBaseEvent> where T : class
    {
    }
}

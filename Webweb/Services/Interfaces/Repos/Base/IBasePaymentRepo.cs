using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBasePaymentRepo<T> : IBaseModelRepo<T, IBasePayment> where T : class
    {
    }
}

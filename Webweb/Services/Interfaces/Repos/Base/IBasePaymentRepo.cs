using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBasePaymentRepo<TModel> : IBaseModelRepo<TModel, BasePayment> where TModel : class
    {
    }
}

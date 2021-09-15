using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;
using Webweb.Services.Interfaces.Repos.Base;
using Webweb.Models.Competitions;

namespace Webweb.Controllers.BaseControllers
{
    public class BasePaymentController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel> where TModel : BasePayment
    {
        public BasePaymentController(IMapper mapper, TISpecificUnitOfWork unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        //[HttpGet("[controller]/byevent/{eventID}")]
        //public async Task<IEnumerable<SortedTraineePayment>> GetByEventID(int eventID)
        //{
        //    var payments = (await _allunit.GetRepo<IBasePaymentRepo<TModel>>().WhereAsync(x => x.EventID == eventID)).AsEnumerable().GroupBy(x => x.TraineeID);
        //    var sortedPayments = new List<SortedTraineePayment>();
        //    foreach (var paymentGroup in payments) {
        //        sortedPayments.Add(new SortedTraineePayment { TraineeID = (int)paymentGroup.Key, AmountPayed = (decimal)paymentGroup.Sum(x => x.Amount) });
        //    }

        //    return sortedPayments;
        //}
    }
}

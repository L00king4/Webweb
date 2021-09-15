using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces.Repos.Base;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.UnitsOfWork
{
    public class GenericUnitOfGroup<
            TEventModel,
            TAttendanceModel,
            TPaymentModel
        >
            where TEventModel : BaseEvent
            where TAttendanceModel : BaseAttendance
            where TPaymentModel : BasePayment
    {
        public GenericUnitOfGroup(AppDbContext db){
            Events = new BaseEventRepo<TEventModel>(db);
            Attendances = new BaseAttendanceRepo<TAttendanceModel>(db);
            Payments = new BasePaymentRepo<TPaymentModel>(db);
        }


        IBaseModelRepo<TEventModel, BaseEvent> Events { set; get; }
        IBaseModelRepo<TAttendanceModel, BaseAttendance> Attendances { set; get; }
        IBaseModelRepo<TPaymentModel, BasePayment> Payments { set; get; }
    }
}

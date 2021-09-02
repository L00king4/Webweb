using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfWork<TEventModel, TAttendanceModel, > where TModel
    {
        public IPayedEventRepo Events { get; private set; }
        public IPayedEventAttendanceRepo Attendances { get; private set; }
        public IPayedEventPaymentRepo Payments { get; private set; }
        public TraineeRepo Trainees { get; private set; }
        public Task<int> SaveAsync();
    }

    struct cock { 
        
    }
}

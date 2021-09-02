using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Repos;
using Webweb.Services.Repos.PayedEvents;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfPayedEvent : UnitOfGroup : ISpecificUnitOfWork
    {
        public UnitOfPayedEvent(AppDbContext db) : base(db)
        {
            Events = new PayedEventRepo(db);
            Attendances = new PayedEventAttendanceRepo(db);
            Payments = new PayedEventPaymentRepo(db);
        }

        public PayedEventRepo Events { get; private set; } 
        public PayedEventAttendanceRepo Attendances { get; private set; }
        public PayedEventPaymentRepo Payments { get; private set; }
    }
}

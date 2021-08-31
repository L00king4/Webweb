using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Interfaces.Repos.PayedEvents;
using Webweb.Services.Repos;
using Webweb.Services.Repos.PayedEvents;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfPayedEvent : IUnitOfPayedEvent
    {
        private readonly AppDbContext _db;
        public UnitOfPayedEvent(AppDbContext db)
        {
            _db = db;
            Events = new PayedEventRepo(db);
            Attendances = new PayedEventAttendanceRepo(db);
            Payments = new PayedEventPaymentRepo(db);
            Trainees = new TraineeRepo(db);
        }

        public IPayedEventRepo Events { get; private set; } 
        public IPayedEventAttendanceRepo Attendances { get; private set; }
        public IPayedEventPaymentRepo Payments { get; private set; }
        public ITraineeRepo Trainees { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}

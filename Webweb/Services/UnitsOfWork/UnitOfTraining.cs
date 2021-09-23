using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.PayedEvents;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Interfaces.Repos.Trainings;
using Webweb.Services.Repos;
using Webweb.Services.Repos.Trainings;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfTraining : IUnitOfTraining
    {
        private readonly AppDbContext _db;
        
        public UnitOfTraining(AppDbContext db, IMapper mapper)
        {
            _db = db;
            Events = new TrainingRepo(db, mapper);
            Attendances = new TrainingAttendanceRepo(db);
            Payments = new TrainingPaymentRepo(db);
            Trainees = new TraineeRepo(db);
        }

        public ITrainingRepo Events { get; private set; }
        public ITrainingAttendanceRepo Attendances { get; private set; }
        public ITrainingPaymentRepo Payments { get; private set; }
        public ITrainingSpanPaymentRepo SpanPayments { get; private set; }
        public TraineeRepo Trainees { get; private set; }

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

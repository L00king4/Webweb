using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces.Units;
using Webweb.Services.Repos;
using Webweb.Services.Repos.Trainings;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfTraining : UnitOfGroup, ISpecificUnitOfWork
    {
        public UnitOfTraining(AppDbContext db) : base(db)
        {
            Events = new TrainingRepo(db);
            Attendances = new TrainingAttendanceRepo(db);
            Payments = new TrainingPaymentRepo(db);
        }

        public IBaseModelRepo Events { get; private set; }
        public TrainingAttendanceRepo Attendances { get; private set; }
        public TrainingPaymentRepo Payments { get; private set; }
    }
}

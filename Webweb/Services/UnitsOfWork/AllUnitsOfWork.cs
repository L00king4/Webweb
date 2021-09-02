using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Interfaces.Repos.Competitions;
using Webweb.Services.Interfaces.Repos.PayedEvents;
using Webweb.Services.Interfaces.Repos.Trainings;
using Webweb.Services.Repos;
using Webweb.Services.Repos.Competitions;
using Webweb.Services.Repos.PayedEvents;
using Webweb.Services.Repos.Trainings;

namespace Webweb.Services.UnitsOfWork
{
    public class AllUnitsOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public AllUnitsOfWork(AppDbContext db)
        {
            _db = db;

            // new Repos();
            Competitions = new CompetitionRepo(db);
            CompetitionAttendances = new CompetitionAttendanceRepo(db);
            CompetitionPayments = new CompetitionPaymentRepo(db);

            PayedEvents = new PayedEventRepo(db);
            PayedEventAttendances = new PayedEventAttendanceRepo(db);
            PayedEventPayments = new PayedEventPaymentRepo(db);

            Trainings = new TrainingRepo(db);
            TrainingAttendances = new TrainingAttendanceRepo(db);
            TrainingPayments = new TrainingPaymentRepo(db);

            Trainees = new TraineeRepo(db);
        }


        // All Repos` props
        public ICompetitionRepo Competitions { get; private set; }
        public ICompetitionAttendanceRepo CompetitionAttendances { get; private set; }
        public ICompetitionPaymentRepo CompetitionPayments { get; private set; }
        public IPayedEventRepo PayedEvents { get; private set; }
        public IPayedEventAttendanceRepo PayedEventAttendances { get; private set; }
        public IPayedEventPaymentRepo PayedEventPayments { get; private set; }
        public ITrainingRepo Trainings { get; private set; }
        public ITrainingAttendanceRepo TrainingAttendances { get; private set; }
        public ITrainingPaymentRepo TrainingPayments { get; private set; }
        public ITraineeRepo Trainees { get; private set; }

        public void Dispose()
        {
           
            _db.Dispose();

        }

        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        public T GetRepo<T>()
        {
            return (T)GetType().GetProperties().FirstOrDefault(x => typeof(T).IsAssignableFrom(x.PropertyType)).GetValue(this);
            //return (T)GetType().GetProperties().FirstOrDefault(x => typeof(T).IsAssignableFrom(x.PropertyType)).GetValue(this);
        }
    }
}

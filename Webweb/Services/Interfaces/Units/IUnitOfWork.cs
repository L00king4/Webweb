using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Interfaces.Repos.Competitions;
using Webweb.Services.Interfaces.Repos.PayedEvents;
using Webweb.Services.Interfaces.Repos.Trainings;

namespace Webweb.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICompetitionRepo Competitions { get; }
        ICompetitionAttendanceRepo CompetitionAttendances { get; }
        ICompetitionPaymentRepo CompetitionPayments { get; }
        IPayedEventRepo PayedEvents { get; }
        IPayedEventAttendanceRepo PayedEventAttendances { get; }
        IPayedEventPaymentRepo PayedEventPayments { get; }
        ITrainingRepo Trainings { get; }
        ITrainingAttendanceRepo TrainingAttendances { get; }
        ITrainingPaymentRepo TrainingPayments { get; }
        ITraineeRepo Trainees { get; }
        Task<int> SaveAsync();
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        //T GetRepo<T>(Type t) where T : class;
        T GetRepo<T>();
    }
}

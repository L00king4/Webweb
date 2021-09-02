using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos.Trainings;

namespace Webweb.Services.Interfaces
{
    public interface IUnitOfTraining : IDisposable, ISpecificUnitOfWork
    {
        ITrainingRepo Events { get; }
        ITrainingAttendanceRepo Attendances { get; }
        ITrainingPaymentRepo Payments { get; }

    }
}

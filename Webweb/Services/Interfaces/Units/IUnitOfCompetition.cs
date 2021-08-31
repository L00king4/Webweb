using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos.Competitions;

namespace Webweb.Services.Interfaces
{
    public interface IUnitOfCompetition : IDisposable, IGroupUnitOfWork
    {
        ICompetitionRepo Events { get; }
        ICompetitionAttendanceRepo Attendances { get; }
        ICompetitionPaymentRepo Payments { get; }
    }
}

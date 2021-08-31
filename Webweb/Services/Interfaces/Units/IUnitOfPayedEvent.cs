using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos.PayedEvents;

namespace Webweb.Services.Interfaces
{
    public interface IUnitOfPayedEvent : IDisposable, IGroupUnitOfWork
    {
        IPayedEventRepo Events { get; }
        IPayedEventAttendanceRepo Attendances { get; }
        IPayedEventPaymentRepo Payments { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.PayedEvents;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Interfaces.Repos.PayedEvents
{
    public interface IPayedEventPaymentRepo : IBasePaymentRepo<PayedEventPayment>
    {
    }
}

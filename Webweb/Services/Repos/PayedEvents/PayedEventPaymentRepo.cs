using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.PayedEvents;
using Webweb.Services.Interfaces.Repos.PayedEvents;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos.PayedEvents
{
    public class PayedEventPaymentRepo : BasePaymentRepo<PayedEventPayment>, IPayedEventPaymentRepo
    {
        public PayedEventPaymentRepo(AppDbContext db) : base(db) { }
    }
}

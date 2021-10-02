using System;
using System.Collections.Generic;
using System.Text;
using WebEntities.DB.Models.BaseModels;

namespace WebEntities.Models.PayedEvents
{
    public class PayedEvent : BaseEvent
    {
        public virtual DateTime? PayUntil { set; get; }
    }
}

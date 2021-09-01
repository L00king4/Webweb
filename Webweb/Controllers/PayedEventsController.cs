using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models.PayedEvents;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{
    public class PayedEventsController : BaseController<IUnitOfPayedEvent, PayedEvent, IBaseEvent>
    {
        public PayedEventsController(IMapper mapper, IUnitOfPayedEvent unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

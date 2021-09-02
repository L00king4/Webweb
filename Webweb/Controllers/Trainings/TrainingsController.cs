using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;
using WebEntities.Models.Trainings;
using Webweb.Controllers.BaseControllers;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers
{
    [Route("trainings")]
    public class TrainingsController : BaseEventController<IUnitOfTraining, Training>
    {
        public TrainingsController(IMapper mapper, IUnitOfTraining unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

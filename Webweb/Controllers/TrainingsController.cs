using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models;
using WebEntities.Models.Trainings;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{
    [Route("trainings")]
    public class TrainingsController : BaseController<IUnitOfTraining, Training, IBaseEvent>
    {
        public TrainingsController(IMapper mapper, IUnitOfTraining unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

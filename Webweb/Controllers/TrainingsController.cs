using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;
using WebEntities.Models.Trainings;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{
    [Route("trainings")]
    public class TrainingsController : BaseController<IUnitOfTraining, Training>
    {
        public TrainingsController(IMapper mapper, IUnitOfTraining unit, IAllUnitsOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

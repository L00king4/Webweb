using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Enums;
using WebEntities.Models;
using WebEntities.Models.Trainings;
using Webweb.Controllers.BaseControllers;
using Webweb.Filters;
using Webweb.Models.Trainings;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers
{
    public class TrainingsController : BaseEventController<IUnitOfTraining, Training>
    {
        public TrainingsController(IMapper mapper, IUnitOfTraining unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        [HttpGet("[controller]/getmonth/{date}")]
        [ValidModelFilter]
        public async Task<TrainingMonth> GetTrainingMonth(DateTime date, [FromQuery] AgeGroup? ageGroup) {
            return await _unit.Events.GetTrainingMonthAsync(date, ageGroup);
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Trainings;
using Webweb.Controllers.BaseControllers;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.Trainings
{
    public class TrainingAttendancesController : BaseAttendanceController<IUnitOfTraining, TrainingAttendance>
    {
        public TrainingAttendancesController(IMapper mapper, IUnitOfTraining unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Controllers.BaseControllers
{
    public class BaseEventController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel, IBaseEvent> where TModel : class where TISpecificUnitOfWork: ISpecificUnitOfWork
    {
        public BaseEventController(IMapper mapper, TISpecificUnitOfWork unit, IAllUnitsOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        [HttpGet("[controller]/{eventID}/trainees")]
        public async Task<SortedTrainees> GetAttendingTrainees(int eventID)
        {

            var attendances = await _unit.Attendances....
                await _allunit.GetRepo<IBaseModelRepo<TModel, IBaseAttendance>>().WhereAsync(x => ((IBaseAttendance)x).EventID == eventID);
            var trainees = await _allunit.Trainees.GetAllAsync();

            var attendingTrainees = trainees.Where(
                x => attendances.Any(
                    y => y.TraineeID == x.ID
                )
            );
            var notAttendingTrainees = await Task.Run(() => trainees.Except(attendingTrainees));
            return new SortedTrainees()
            {
                AttendingTrainees = attendingTrainees.ToList(),
                NotAttendingTrainees = notAttendingTrainees.ToList()
            };
        }
    }
}

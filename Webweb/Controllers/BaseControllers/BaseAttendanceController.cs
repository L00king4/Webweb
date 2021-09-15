using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using WebEntities.Models.Competitions;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.BaseControllers
{
    public class BaseAttendanceController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel> where TModel : BaseAttendance
    {

        public BaseAttendanceController(IMapper mapper, TISpecificUnitOfWork unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }


        [HttpGet("[controller]/byevent/{eventID}")]
        public async Task<IEnumerable<TModel>> GetByEventID(int eventID)
        {
            return await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().WhereAsync(x => x.EventID == eventID);
        }

        //[HttpGet("[controller]/{eventID}/trainees")]
        //public async Task<SortedTrainees> GetAttendingTrainees(int eventID)
        //{

        //    var attendances = await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().WhereAsync(x => x.EventID == eventID);
        //    var trainees = await _allunit.Trainees.GetAllAsync();

        //    var attendingTrainees = trainees.Where(
        //        x => attendances.Any(
        //            y => y.TraineeID == x.ID
        //        )
        //    );
        //    var notAttendingTrainees = await Task.Run(() => trainees.Except(attendingTrainees));
        //    return new SortedTrainees()
        //    {
        //        AttendingTrainees = attendingTrainees.ToList(),
        //        NotAttendingTrainees = notAttendingTrainees.ToList()
        //    };
        //}

        [HttpPost("[controller]/add")]
        public override async Task<int> Add([FromBody] TModel model)
        {
            if (!await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().AlreadyExistsAsync(model))
            {
                return await base.Add(model);
            }

            return -1;
        }

        [HttpPost("[controller]/remove")]
        public async Task<int> Remove([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid)
            {
                await _allunit.GetRepo<IBaseModelRepo<TModel, BaseAttendance>>().RemoveAsync(model);
                return await _allunit.SaveAsync();
            }

            return -1;
        }
    }
}

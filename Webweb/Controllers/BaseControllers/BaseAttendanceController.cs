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
using Webweb.Filters;

namespace Webweb.Controllers.BaseControllers
{
    public class BaseAttendanceController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel> where TModel : BaseAttendance
    {

        public BaseAttendanceController(IMapper mapper, TISpecificUnitOfWork unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        [HttpGet("[controller]")]
        [HttpGet("[controller]/all")]
        [ValidModelFilter]
        public async Task<IEnumerable<TModel>> GetAll()
        {
            return await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().GetAllAsync();
        }

        [HttpGet("[controller]/byevent/{eventID}")]
        public async Task<IEnumerable<TModel>> GetByEventID(int eventID)
        {
            return await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().WhereAsync(x => x.EventID == eventID);
        }


        [HttpPost("[controller]/add")]
        [ValidModelFilter]
        public override async Task<int> Add([FromBody] TModel model)
        {
            if (!await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().AlreadyExistsAsync(model))
            {
                return await base.Add(model);
            }

            return -1;
        }

        [HttpPost("[controller]/addrange/unique")]
        [ValidModelFilter]
        public virtual async Task<int> AddUniqueRange([FromBody] IEnumerable<TModel> models)
        {
            await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().AddUniqueRangeAsync(models);
            return await _allunit.SaveAsync();
        }

        [HttpPost("[controller]/remove")]
        [ValidModelFilter]
        public async Task<int> Remove([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid)
            {
                await _allunit.GetRepo<IBaseAttendanceRepo<TModel>>().RemoveAsync(model);
                return await _allunit.SaveAsync();
            }

            return -1;
        }
    }
}

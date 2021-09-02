using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Controllers.BaseControllers
{
    public class BaseAttendanceController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel, IBaseAttendance> where TModel: class
    {
        public BaseAttendanceController(IMapper mapper, TISpecificUnitOfWork unit, IAllUnitsOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        [HttpGet("[controller]/{eventID}")]
        public async Task<IEnumerable<TModel>> GetByEventID(int eventID)
        {

            return await _allunit.GetRepo<IBaseModelRepo<TModel, IBaseAttendance>>().WhereAsync(x => ((IBaseAttendance)x).EventID == eventID);
        }

        [HttpPost("[controller]/add")]
        public async Task<int> AddIfUnique([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid && !await _allunit.GetRepo<IBaseModelRepo<TModel, IBaseAttendance>>().AlreadyExistsAsync(model))
            {
                await Task.Run(() => _allunit.GetRepo<IBaseModelRepo<TModel, IBaseAttendance>>().AddAsync(model));
                return await _allunit.SaveAsync();

            }

            return -1;
        }

        [HttpPost("[controller]/remove")]
        public async Task<int> Remove([FromBody] CompetitionAttendance model)
        {
            if (ModelState.IsValid)
            {
                await _allunit.GetRepo<IBaseModelRepo<TModel, IBaseAttendance>>().RemoveAsync(model);
                return await _allunit.SaveAsync();
            }

            return -1;
        }
    }
}

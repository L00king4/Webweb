using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;
using Webweb.Services.UnitsOfWork;
using Webweb.Filters;
using WebEntities.Enums;

namespace Webweb.Controllers.BaseControllers
{
    public class BaseEventController<TISpecificUnitOfWork, TModel> 
        : BaseController<TISpecificUnitOfWork, TModel> 
        where TModel : BaseEvent
        where TISpecificUnitOfWork: ISpecificUnitOfWork
    {
        public BaseEventController(IMapper mapper, TISpecificUnitOfWork unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }

        [HttpGet("[controller]")]
        [HttpGet("[controller]/all")]
        [ValidModelFilter]
        public async Task<IEnumerable<TModel>> GetAll([FromQuery] AgeGroup? ageGroup)
        {
            return await _allunit.GetRepo<IBaseEventRepo<TModel>>().GetAllByAgeGroupAsync(ageGroup); 
        }

        [HttpPost("[controller]/add")]
        [ValidModelFilter]
        public override async Task<int> Add([FromBody] TModel model)
        {
            if (!await _allunit.GetRepo<IBaseEventRepo<TModel>>().AlreadyExistsAsync(model))
            {
                var entity = await _allunit.GetRepo<IBaseEventRepo<TModel>>().AddAsync(model);
                if (await _allunit.SaveAsync() > 0) {
                    return entity.ID;
                }
            }

            return -1;
        }
    }
}

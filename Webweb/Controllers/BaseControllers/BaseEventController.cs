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

        [HttpPost("[controller]/add")]
        public override async Task<int> Add([FromBody] TModel model)
        {
            if (ModelState.IsValid && !await _allunit.GetRepo<IBaseEventRepo<TModel>>().AlreadyExistsAsync(model))
            {
                var entity = await _allunit.GetRepo<IBaseRepo<TModel>>().AddAsync(model);
                if (await _allunit.SaveAsync() > 0) {
                    return entity.ID;
                }
            }

            return -1;
        }
    }
}

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
        : BaseController<TISpecificUnitOfWork, TModel, BaseEvent> 
        where TModel : BaseEvent
        where TISpecificUnitOfWork: ISpecificUnitOfWork
    {
        public BaseEventController(IMapper mapper, TISpecificUnitOfWork unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.BaseControllers
{
    public class BasePaymentController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel, BasePayment> where TModel: class
    {
        public BasePaymentController(IMapper mapper, TISpecificUnitOfWork unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

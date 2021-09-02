using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers.BaseControllers
{
    public class BasePaymentController<TISpecificUnitOfWork, TModel> : BaseController<TISpecificUnitOfWork, TModel, IBasePayment> where TModel: class
    {
        public BasePaymentController(IMapper mapper, TISpecificUnitOfWork unit, IAllUnitsOfWork allunit) : base(mapper, unit, allunit)
        {
        }
    }
}

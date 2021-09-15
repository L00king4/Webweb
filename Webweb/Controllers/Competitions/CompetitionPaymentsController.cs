using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Competitions;
using Webweb.Controllers.BaseControllers;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.Competitions
{
    public class CompetitionPaymentsController : BasePaymentController<IUnitOfCompetition, CompetitionPayment>
    {
        public CompetitionPaymentsController(IMapper mapper, IUnitOfCompetition unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }
        

    }
}

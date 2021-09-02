using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Competitions;
using Webweb.Controllers.BaseControllers;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers.Competitions
{
    public class CompetitionPaymentsController : BasePaymentController<IUnitOfCompetition, CompetitionPayment>
    {
        public CompetitionPaymentsController(IMapper mapper, IUnitOfCompetition unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }


    }
}

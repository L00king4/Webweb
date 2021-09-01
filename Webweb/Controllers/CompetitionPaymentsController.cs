using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{
    public class CompetitionPaymentsController : BaseController<IUnitOfCompetition, CompetitionPayment, IBasePayment>
    {
        public CompetitionPaymentsController(IMapper mapper, IUnitOfCompetition unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }


    }
}

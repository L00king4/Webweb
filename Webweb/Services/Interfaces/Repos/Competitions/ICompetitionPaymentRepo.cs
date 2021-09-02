using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Interfaces.Repos.Competitions
{
    public interface ICompetitionPaymentRepo : IBasePaymentRepo<CompetitionPayment>
    {
    }
}

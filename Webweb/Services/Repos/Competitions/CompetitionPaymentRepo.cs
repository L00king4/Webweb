using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.Competitions;
using Webweb.Services.Interfaces.Repos.Competitions;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos.Competitions
{
    public class CompetitionPaymentRepo : BasePaymentRepo<CompetitionPayment>, ICompetitionPaymentRepo
    {
        public CompetitionPaymentRepo(AppDbContext db) : base(db) { }
    }
}

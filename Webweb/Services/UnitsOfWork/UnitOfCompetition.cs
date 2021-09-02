using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Repos;
using Webweb.Services.Repos.Competitions;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfCompetition 
        : UnitOfGroup
    {
        public UnitOfCompetition(AppDbContext db) : base(db)
        {
            Events = new CompetitionRepo(db);
            Attendances = new CompetitionAttendanceRepo(db);
            Payments = new CompetitionPaymentRepo(db);
        }
    }
}

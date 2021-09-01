using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.Competitions;
using Webweb.Services.Repos.Base;
using Webweb.Services.Interfaces.Repos.Competitions;
using System.Linq.Expressions;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Repos.Competitions
{
    public class CompetitionAttendanceRepo : BaseAttendanceRepo<CompetitionAttendance>, ICompetitionAttendanceRepo
    {
        public CompetitionAttendanceRepo(AppDbContext db) : base(db)
        {
        }
    }
}

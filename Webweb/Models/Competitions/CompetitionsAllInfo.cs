using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;
using WebEntities.Models.Competitions;

namespace Webweb.Models.Competitions
{
    public class CompetitionsAllInfo
    {
        public Competition Competition { set; get; }
        public IEnumerable<Trainee> AttendingTrainees { set; get; }
        public IEnumerable<Trainee> NotAttendingTrainees { set; get; }
    }
}

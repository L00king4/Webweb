using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;

namespace Webweb.Models.Competitions
{
    public class SortedTrainees
    {
        public IEnumerable<Trainee> AttendingTrainees { set; get; }
        public IEnumerable<Trainee> NotAttendingTrainees { set; get; }

    }
}

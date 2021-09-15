using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;

namespace Webweb.Models.Competitions
{
    public class SortedTrainees
    {
        public IEnumerable<SortedTraineePayment> AttendingTrainees { set; get; }
        public IEnumerable<SortedTraineePayment> NotAttendingTrainees { set; get; }

    }
}

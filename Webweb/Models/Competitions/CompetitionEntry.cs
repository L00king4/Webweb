using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Competitions;

namespace Webweb.Models.Competitions
{
    public class CompetitionEntry
    {
        public SortedTrainees SortedTrainees { set; get; }
        public Competition Competition { set; get; }
    }
}

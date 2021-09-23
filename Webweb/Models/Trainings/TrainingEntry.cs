using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webweb.Models.Trainings
{
    public class TrainingEntry
    {
        public int EventID { set; get; }
        public decimal PayedAmount { set; get; }
        public bool HasAttended { set; get; }
    }
}

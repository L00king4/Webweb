using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.BaseModels;
using WebEntities.Models;

namespace Webweb.Models.Competitions
{
    public class SortedTraineePayment : Trainee
    {
        public decimal AmountPayed { set; get; } = 0;
    }
}

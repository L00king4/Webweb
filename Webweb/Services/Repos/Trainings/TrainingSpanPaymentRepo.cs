using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Trainings;
using WebEntities.Models.Trainings;
using Webweb.Services.Interfaces.Repos.Trainings;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos.Trainings
{
    public class TrainingSpanPaymentRepo : BasePaymentRepo<TrainingSpanPayment>, ITrainingSpanPaymentRepo
    {
        public TrainingSpanPaymentRepo(AppDbContext db) : base(db)
        {
        }
    }
}

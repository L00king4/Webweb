using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos.Base;
using WebEntities.DB.Models.Trainings;

namespace Webweb.Services.Interfaces.Repos.Trainings
{
    public interface ITrainingSpanPaymentRepo : IBasePaymentRepo<TrainingSpanPayment>
    {
    }
}

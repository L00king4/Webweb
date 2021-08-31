using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Trainings;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Interfaces.Repos.Trainings
{
    public interface ITrainingPaymentRepo : IBasePaymentRepo<TrainingPayment>
    {
    }
}

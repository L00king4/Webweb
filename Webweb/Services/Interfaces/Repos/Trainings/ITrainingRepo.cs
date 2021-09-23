using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Enums;
using WebEntities.Models.Trainings;
using Webweb.Models.Trainings;
using Webweb.Services.Interfaces.Repos.Base;


namespace Webweb.Services.Interfaces.Repos.Trainings
{
    public interface ITrainingRepo : IBaseEventRepo<Training>
    {
        public Task<TrainingMonth> GetTrainingMonthAsync(DateTime date, AgeGroup ageGroup);
    }
}

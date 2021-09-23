using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.Trainings;

namespace Webweb.Models.Trainings
{
    public class TrainingMonth
    {
        public IEnumerable<TrainingInfo> TrainingInfos { set; get; } = new List<TrainingInfo>();
        public IEnumerable<TrainingTrainee> TrainingTrainees { set; get; } = new List<TrainingTrainee>();
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models;

namespace Webweb.Models.Trainings
{
    public class TrainingTrainee
    {
        public Trainee Trainee { set; get; }
        public IEnumerable<TrainingEntry> TrainingEntries { set; get; } = new List<TrainingEntry>();
        public IEnumerable<TrainingPayedSpan> TrainingPayedSpans { set; get; } = new List<TrainingPayedSpan>();
    }
}

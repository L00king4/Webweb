using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Enums;
using WebEntities.Models.Trainings;
using Webweb.Models.Trainings;
using Webweb.Services.Interfaces.Repos.Trainings;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos.Trainings
{
    public class TrainingRepo : BaseEventRepo<Training>, ITrainingRepo
    {
        private IMapper _mapper { get; }
        public TrainingRepo(AppDbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        public async Task<TrainingMonth> GetTrainingMonthAsync(DateTime date, AgeGroup ageGroup)
        {
            var start = DateTime.Now;
            var trainingMonth = new TrainingMonth();
            var trainings = _db.Trainings.AsEnumerable().Where(x => (ageGroup == AgeGroup.All || x.AgeGroup == ageGroup) && x.Date.Value.Month == date.Month && x.Date.Value.Year == date.Year).ToList();
            var trainees = _db.Trainees.AsEnumerable().Where(x => ageGroup == AgeGroup.All || x.AgeGroup == ageGroup).ToList();
            var attendances = _db.TrainingAttendance.AsEnumerable().Where(x => trainings.Any(y => y.ID == x.EventID)).ToList();
            var singlePayments = _db.TrainingPayments.AsEnumerable().Where(x => trainings.Any(y => y.ID == x.EventID)).ToList();
            var spanPayments = _db.TrainingSpanPayments.AsEnumerable().Where(x => trainings.Any(y => y.ID == x.EventID)).ToList();

            //var singlePaymentsGroup = singlePayments.GroupBy(x => (x.EventID, x.TraineeID), x => new TrainingEntry { PayedAmount = x.Amount, EventID = x.EventID });
            //var attendancesGroup = attendances.GroupBy(x => (x.EventID, x.TraineeID), x => new TrainingEntry { HasAttended = true, EventID = x.EventID });

            //foreach (var trainee in trainees)
            //{
            //    trainingMonth.TrainingTrainees = trainingMonth.TrainingTrainees.Append(new TrainingTrainee() { Trainee = trainee });
            //}

            //var groups = singlePaymentsGroup.Concat(attendancesGroup).GroupBy(x => x.Key);
            //foreach (var trainee in trainingMonth.TrainingTrainees)
            //{
            //    foreach (var training in trainings)
            //    {
            //        try
            //        {
            //            var newTrainingEntry = groups.First(x => x.Key.EventID == training.ID && x.Key.TraineeID == trainee.Trainee.ID)
            //                .Select(x => new TrainingEntry
            //                {
            //                    EventID = x.Key.Item1,
            //                    PayedAmount = x.Sum(y => y.PayedAmount),
            //                    HasAttended = x.Any(y => y.HasAttended)
            //                }).First();
            //            trainee.TrainingEntries = trainee.TrainingEntries.Append(newTrainingEntry);
            //        }
            //        catch
            //        {

            //        }
            //    }
            //}

            var neutralEntriesFromPayments = singlePayments.GroupBy(d => (d.EventID, d.TraineeID))
                        .Select(
                            g => new TrainingEntryNeutral
                            {
                                EventID = g.Key.EventID,
                                TraineeID = g.Key.TraineeID,
                                PayedAmount = g.Sum(s => s.Amount),
                                HasAttended = false
                            });
            var neutralEntriesFromAttendances = attendances.GroupBy(d => (d.EventID, d.TraineeID))
                           .Select(g => new TrainingEntryNeutral
                           {
                               EventID = g.Key.EventID,
                               TraineeID = g.Key.TraineeID,
                               PayedAmount = 0,
                               HasAttended = true
                           });
            var allNeutralEntries = neutralEntriesFromPayments.Concat(neutralEntriesFromAttendances);
            var trainingTraineesGroups = allNeutralEntries.GroupBy(x => (x.TraineeID, x.EventID))
                        .Select(
                x => new TrainingEntryNeutral
                {
                    EventID = x.Key.EventID,
                    TraineeID = x.Key.TraineeID,
                    PayedAmount = x.Sum(y => y.PayedAmount),
                    HasAttended = x.Any(y => y.HasAttended)
                }).GroupBy(x => x.TraineeID, x => (TrainingEntry)x);

            foreach (var spanPayment in _mapper.Map<IEnumerable<TrainingPayedSpan>>(spanPayments))
            {
                try
                {
                    var list = trainingMonth.TrainingTrainees.FirstOrDefault(x => x.Trainee.ID == spanPayment.TraineeID);
                    list.TrainingPayedSpans = list.TrainingPayedSpans.Append(spanPayment);
                }
                catch
                {
                }
            }


            IEnumerable<TrainingEntry> emptyList = new List<TrainingEntry>();
            foreach (var trainee in trainees)
            {
                IEnumerable<TrainingEntry> trainingEntries = trainingTraineesGroups.FirstOrDefault(x => x.Key == trainee.ID);
                if (trainingEntries == null)
                {
                    trainingEntries = emptyList;
                }
                trainingMonth.TrainingTrainees = trainingMonth.TrainingTrainees.Append(
                new TrainingTrainee
                {
                    Trainee = trainee,
                    TrainingEntries = trainingEntries,//trainingTraineesGroups.First(x => x.Key == trainee.ID),
                    TrainingPayedSpans = _mapper.Map<IEnumerable<TrainingPayedSpan>>(spanPayments.Where(x => x.TraineeID == trainee.ID).ToList())
                }
                );

            }
            trainingMonth.TrainingInfos = _mapper.Map<IEnumerable<TrainingInfo>>(trainings);

            Console.WriteLine((DateTime.Now - start).Milliseconds);
            return trainingMonth;
        }
    }
}

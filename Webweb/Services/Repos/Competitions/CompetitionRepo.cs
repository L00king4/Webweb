using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.Competitions;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces.Repos.Competitions;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos.Competitions
{
    public class CompetitionRepo : BaseEventRepo<Competition>, ICompetitionRepo
    {
        private IMapper _mapper;
        public CompetitionRepo(AppDbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        //public async Task<CompetitionEntry> GetCompetitionEntryAsync(int eventID)
        //{
        //    return new CompetitionEntry
        //    {
        //        Competition = await base.GetByIDAsync(eventID),
        //        SortedTrainees = await GetSortedTraineesAsync(eventID),
        //    };
        //}

        public async Task<SortedTrainees> GetSortedTraineesAsync(int eventID)
        {
            var attendances = _db.CompetitionAttendances.Where(x => x.EventID == eventID);
            var trainees = _mapper.Map<IEnumerable<SortedTraineePayment>>(_db.Trainees.ToList());
            var payments = (_db.CompetitionPayments.Where(x => x.EventID == eventID)).AsEnumerable().GroupBy(x => x.TraineeID);

            foreach (var paymentGroup in payments)
            {
                try
                {
                    trainees.First(x => x.ID == paymentGroup.Key).AmountPayed = (decimal)paymentGroup.Sum(x => x.Amount);
                }
                catch
                {

                }
            }

            var attendingTrainees = trainees.Where(
                x => attendances.Any(
                    y => y.TraineeID == x.ID
                )
            );

            var notAttendingTrainees = await Task.Run(() => trainees.Except(attendingTrainees));

            return new SortedTrainees()
            {
                AttendingTrainees = attendingTrainees.ToList(),
                NotAttendingTrainees = notAttendingTrainees.ToList()
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Interfaces.Repos.Competitions;
using Webweb.Services.Repos;
using Webweb.Services.Repos.Competitions;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfCompetition : IUnitOfCompetition
    {
        private readonly AppDbContext _db;
        public UnitOfCompetition(AppDbContext db)
        {
            _db = db;
            Events = new CompetitionRepo(db);
            Attendances = new CompetitionAttendanceRepo(db);
            Payments = new CompetitionPaymentRepo(db);
            Trainees = new TraineeRepo(db);
        }

        public ICompetitionRepo Events { get; private set; }
        public ICompetitionAttendanceRepo Attendances { get; private set; }
        public ICompetitionPaymentRepo Payments { get; private set; }
        public TraineeRepo Trainees { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}

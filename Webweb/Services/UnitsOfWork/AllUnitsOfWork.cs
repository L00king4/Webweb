using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;

namespace Webweb.Services.UnitsOfWork
{
    public class AllUnitsOfWork : IDisposable
    {
        private readonly AppDbContext _db;
        public AllUnitsOfWork(AppDbContext db)
        {
            _db = db;

            // new Repos();
            Competitions = new UnitOfCompetition(db);
            PayedEvents = new UnitOfPayedEvent(db);
            Trainings = new UnitOfTraining(db);
        }


        // All Repos` props
        public UnitOfCompetition Competitions { get; private set; }
        public UnitOfPayedEvent PayedEvents { get; private set; }
        public UnitOfTraining Trainings { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        public TUnit GetUnit<TUnit>() {
            return (TUnit) this.GetType().GetProperties().First(x => typeof(TUnit).IsEquivalentTo(x.PropertyType)).GetValue(this);
        }
    }
}

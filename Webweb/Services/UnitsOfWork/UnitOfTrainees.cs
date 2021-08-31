using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Interfaces.Units;
using Webweb.Services.Repos;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfTrainee : IUnitOfTrainee
    {
        private readonly AppDbContext _db;
        public UnitOfTrainee(AppDbContext db)
        {
            _db = db;
            Trainees = new TraineeRepo(db);
        }

        public ITraineeRepo Trainees { get; private set; }

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

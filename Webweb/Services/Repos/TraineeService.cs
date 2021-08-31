using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DBmodels;
using Webweb.Models.Main;

namespace Webweb.Controllers.Main.Services.Specific
{
    public class TraineeService : BaseDBService, IService<Trainee>
    {
        public TraineeService(AppDbContext appDbContext) : base(appDbContext) { }

        public bool Add(Trainee T)
        {
            _db.Trainees.Add(T);
            return _db.SaveChanges() > 0;
        }

        public async Task<bool> AddAsync(Trainee T)
        {
            await _db.Trainees.AddAsync(T);
            return await _db.SaveChangesAsync() > 0;
        }

        public ICollection<Trainee> List()
        {
            return _db.Trainees.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DBmodels;

namespace Webweb.Controllers.Main.Services.Specific
{
    public class EventTraineeService : BaseDBService, IService<EventTrainee>
    {
        public EventTraineeService(AppDbContext appDbContext) : base(appDbContext) { }
        public bool Add(EventTrainee T)
        {
            _db.EventTrainees.Add(T);
            return _db.SaveChanges() > 0;
        }

        public async Task<bool> AddAsync(EventTrainee T)
        {
            await _db.EventTrainees.AddAsync(T);
            return await _db.SaveChangesAsync() > 0;
        }

        public ICollection<EventTrainee> List()
        {
            return _db.EventTrainees.ToList();
        }
    }
}

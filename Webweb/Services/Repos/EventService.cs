using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DBmodels;

namespace Webweb.Controllers.Main.Services.Specific
{
    public class EventService : IService<Event>
    {
        private readonly AppDbContext _db;
        public EventService(AppDbContext db) {
            _db = db;
        }

        public bool Add(Event T)
        {
            _db.Events.Add(T);
            return _db.SaveChanges() > 0;
        }

        public async Task<bool> AddAsync(Event T) {
            await _db.Events.AddAsync(T);
            return await _db.SaveChangesAsync() > 0;
        }

        public ICollection<Event> List()
        {
            throw new NotImplementedException();
        }

        //public async Task<ICollection<Event>> ListAsync()
        //{
        //    return await _db.Events.ToListAsync();
        //}
    }
}

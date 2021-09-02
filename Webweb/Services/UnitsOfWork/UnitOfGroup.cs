using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using Webweb.Services.Repos;

namespace Webweb.Services.UnitsOfWork
{
    public class UnitOfGroup
    {
        private readonly AppDbContext _db;
        public UnitOfGroup(AppDbContext db) {
            _db = db;
        }
        public TraineeRepo Trainees { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }
        public T GetRepo<T>()
        {
            return (T)GetType().GetProperties().FirstOrDefault(x => typeof(T).IsAssignableFrom(x.PropertyType)).GetValue(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Repos.Base
{
    public class BaseAttendanceRepo<T> : BaseRepo<T>, IBaseAttendanceRepo<T> where T : BaseAttendance
    {
        public BaseAttendanceRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<bool> AlreadyExistsAsync(BaseAttendance model)
        {
            return await GetByModelAsync(model) != null;
        }

        public virtual async Task RemoveAsync(BaseAttendance model)
        {
            var a = await GetByModelAsync(model);
            if (a != null)
            {
                await Task.Run(() => _db.Set<T>().Remove(a));
            }
        }

        public virtual async Task RemoveRangeAsync(BaseAttendance model)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByModelAsync(BaseAttendance model)
        {
            return await FirstAsync(
                x => x.TraineeID == model.TraineeID && x.EventID == model.EventID
            );
        }

        public virtual void ClearAttendancesFromEvent(int eventID) {
            var a = _db.Set<T>().Where(x => x.EventID == eventID);
            _db.Set<T>().RemoveRange(a.AsEnumerable());
        }
    }
}

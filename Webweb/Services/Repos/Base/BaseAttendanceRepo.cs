using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Repos.Base
{
    public class BaseAttendanceRepo<T> : BaseRepo<T>, IBaseAttendanceRepo<T> where T : class
    {
        public BaseAttendanceRepo(AppDbContext db) : base(db)
        {
        }

        public virtual async Task<bool> AlreadyExistsAsync(IBaseAttendance model)
        {
            return await GetByModelAsync(model) != null;
        }

        public virtual async Task RemoveAsync(IBaseAttendance model)
        {
            var a = await GetByModelAsync(model);
            await Task.Run(() => _db.Set<T>().Remove(a));
        }

        public virtual async Task RemoveRangeAsync(IBaseAttendance model)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByModelAsync(IBaseAttendance model)
        {
            return await FirstAsync(
                x => ((IBaseAttendance)x).TraineeID == model.TraineeID && ((IBaseAttendance)x).EventID == model.EventID
            );
        }
    }
}

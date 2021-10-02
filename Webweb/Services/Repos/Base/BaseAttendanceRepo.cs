using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;
using Webweb.Services.Interfaces.Repos.Base;
using Microsoft.EntityFrameworkCore;

namespace Webweb.Services.Repos.Base
{
    public class BaseAttendanceRepo<TModel> : BaseRepo<TModel>, IBaseAttendanceRepo<TModel> where TModel : BaseAttendance
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
                await Task.Run(() => _db.Set<TModel>().Remove(a));
            }
        }

        public virtual async Task RemoveRangeAsync(BaseAttendance model)
        {
            throw new NotImplementedException();
        }

        public async Task<TModel> GetByModelAsync(BaseAttendance model)
        {
            return await FirstAsync(
                x => x.TraineeID == model.TraineeID && x.EventID == model.EventID
            );
        }

        public virtual void ClearAttendancesFromEvent(int eventID) {
            var a = _db.Set<TModel>().Where(x => x.EventID == eventID);
            _db.Set<TModel>().RemoveRange(a.AsEnumerable());
        }

        public virtual async Task AddUniqueRangeAsync(IEnumerable<TModel> models)
        {
            foreach(var model in models)
            {
                bool hasAlready = await _db.Set<TModel>().AnyAsync(x => x.EventID == model.EventID && x.TraineeID == model.TraineeID);
                if (!hasAlready) {
                    await AddAsync(model);
                }
            }
        }
    }
}

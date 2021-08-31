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
            return await Task.Run(() => _db.Set<T>().FirstOrDefault(
               x => ((IBaseAttendance) x).EventID == model.EventID && ((IBaseAttendance)x).TraineeID == model.TraineeID
            ) != null);
        }
    }
}

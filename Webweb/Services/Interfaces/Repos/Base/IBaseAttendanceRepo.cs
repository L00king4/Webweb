using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.DB.Models.BaseModels;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseAttendanceRepo<TModel> : IBaseModelRepo<TModel, BaseAttendance> where TModel : class, IBaseModel
    {
        public void ClearAttendancesFromEvent(int eventID);
        public Task AddUniqueRangeAsync(IEnumerable<TModel> models);
    }
}

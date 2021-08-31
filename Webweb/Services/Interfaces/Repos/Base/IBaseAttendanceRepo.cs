using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;

namespace Webweb.Services.Interfaces.Repos.Base
{
    public interface IBaseAttendanceRepo<T> : IBaseModelRepo<T, IBaseAttendance> where T : class
    {
    }
}

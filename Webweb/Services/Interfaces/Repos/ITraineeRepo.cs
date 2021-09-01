using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models;
using Webweb.Services.Interfaces.Repos.Base;

namespace Webweb.Services.Interfaces.Repos
{
    public interface ITraineeRepo : IBaseModelRepo<Trainee, IBaseTrainee>
    {
    }
}

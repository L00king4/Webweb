using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos
{
    public class TraineeRepo : BaseRepo<Trainee>, ITraineeRepo
    {
        public TraineeRepo(AppDbContext db) : base(db)
        {
        }
    }
}

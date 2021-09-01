using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.Interfaces;
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

        public Task<bool> AlreadyExistsAsync(IBaseTrainee model)
        {
            throw new NotImplementedException();
        }

        public Task<Trainee> GetByModelAsync(IBaseTrainee model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(IBaseTrainee model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(IBaseTrainee model)
        {
            throw new NotImplementedException();
        }
    }
}

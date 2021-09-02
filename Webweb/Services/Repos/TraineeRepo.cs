using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DB.Models.BaseModels;
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

        public Task<bool> AlreadyExistsAsync(BaseTrainee model)
        {
            throw new NotImplementedException();
        }

        public Task<Trainee> GetByModelAsync(BaseTrainee model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(BaseTrainee model)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(BaseTrainee model)
        {
            throw new NotImplementedException();
        }
    }
}

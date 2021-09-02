using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities.Models.BaseModels;
using Webweb.Services.Interfaces.Repos.Base;
using Webweb.Services.Repos;

namespace Webweb.Services.Interfaces.Units
{
    interface ISpecificUnitOfWork : IDisposable
    {
        IBaseModelRepo<BaseEvent> Events { get; }
        IBaseModelRepo<BaseAttandance> Attendances { get; }
        IBaseModelRepo<BasePayment> Payments { get; }
        public TraineeRepo Trainees { get;}
        public Task<int> SaveAsync();
        public IBaseModelRepo<T> GetRepo<T>();
    }
}

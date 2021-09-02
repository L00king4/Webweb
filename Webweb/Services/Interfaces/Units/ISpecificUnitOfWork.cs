using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos;
using Webweb.Services.Repos;

namespace Webweb.Services.Interfaces
{
    public interface ISpecificUnitOfWork : IDisposable
    {
        TraineeRepo Trainees { get; }
        Task<int> SaveAsync();
    }
}

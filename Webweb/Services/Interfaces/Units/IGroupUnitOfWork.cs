using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webweb.Services.Interfaces.Repos;

namespace Webweb.Services.Interfaces
{
    public interface IGroupUnitOfWork : IDisposable
    {
        ITraineeRepo Trainees { get; }
        Task<int> SaveAsync();
    }
}

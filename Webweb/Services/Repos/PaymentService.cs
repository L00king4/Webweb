using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.DBmodels;

namespace Webweb.Controllers.Main.Services.Specific
{
    public class PaymentService : BaseDBService, IService<Payment>
    {
        public PaymentService(AppDbContext appDbContext) : base(appDbContext) { }
        public bool Add(Payment T)
        {
            _db.Payments.Add(T);
            return _db.SaveChanges() > 0;
        }

        public async Task<bool> AddAsync(Payment T)
        {
            await _db.Payments.AddAsync(T);
            return await _db.SaveChangesAsync() > 0;
        }

        public ICollection<Payment> List()
        {
            return _db.Payments.ToList();
        }
    }
}

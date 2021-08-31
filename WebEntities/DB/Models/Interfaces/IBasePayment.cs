using System;
using System.Collections.Generic;
using System.Text;

namespace WebEntities.DB.Models.Interfaces
{
    public interface IBasePayment : IBaseModel
    {
        public int ID { set; get; }
        public DateTime PayedAt { set; get; }
        public decimal? Amount { set; get; }
        public int? AttendanceID { set; get; }
        public int? TraineeID { set; get; }
        public int? EventID { set; get; }
    }
}

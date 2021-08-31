using System;
using System.Collections.Generic;
using System.Text;

namespace WebEntities.DB.Models.Interfaces
{
    public interface IBaseAttendance : IBaseModel
    {
        public int ID { set; get; }
        public int? TraineeID { set; get; }
        public int? EventID { set; get; }
    }
}

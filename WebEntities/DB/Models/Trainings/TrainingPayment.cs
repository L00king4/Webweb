using System;
using System.Collections.Generic;
using System.Text;
using WebEntities.Models.BaseModels;

namespace WebEntities.Models.Trainings
{
    public class TrainingPayment : BasePayment<Training, TrainingAttendance>
    {
        public DateTime StartTimePayed { set; get; }
        public DateTime EndTimePayed { set; get; }
    }
}

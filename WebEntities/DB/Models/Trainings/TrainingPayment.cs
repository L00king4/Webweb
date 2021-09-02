using System;
using System.Collections.Generic;
using System.Text;
using WebEntities.DB.Models.BaseModels;

namespace WebEntities.Models.Trainings
{
    public class TrainingPayment : BasePayment
    {
        public DateTime StartTimePayed { set; get; }
        public DateTime EndTimePayed { set; get; }
    }
}

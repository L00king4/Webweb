using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.BaseModels;

namespace WebEntities.DB.Models.Trainings
{
    public class TrainingSpanPayment : BasePayment
    {
        [Required]
        public DateTime SpanPayedStart { set; get; }
        [Required]
        public DateTime SpanPayedEnd { set; get; }
    }
}

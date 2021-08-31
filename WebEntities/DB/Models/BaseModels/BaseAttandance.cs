using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.Models.BaseModels
{
    public class BaseAttandance<TEvent, TPayment> : IBaseAttendance
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public int? TraineeID { set; get; }
        private Trainee Trainee { set; get; }
        [Required]
        public int? EventID { set; get; }
        private TEvent Event { set; get; }
        private ICollection<TPayment> Payments { set; get; }
    }
}

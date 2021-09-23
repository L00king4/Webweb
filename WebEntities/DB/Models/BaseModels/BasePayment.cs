using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.DB.Models.BaseModels
{
    public class BasePayment : IBaseModel
    {
        [Key]
        public int ID { set; get; }
        public virtual string Description { set; get; }
        public virtual DateTime PayedAt { set; get; } = DateTime.Now;
        [Required]
        [Range(1, 65535)]
        public virtual decimal Amount { set; get; }
        //[Required]
        //public int? AttendanceID { set; get; }

        [Required]
        public virtual int TraineeID { set; get; }

        [Required]
        public virtual int EventID { set; get; }
    }
}

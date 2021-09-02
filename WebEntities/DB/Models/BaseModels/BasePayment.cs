using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.Models.BaseModels
{
    public class BasePayment
    {
        [Key]
        public int ID { set; get; }
        public DateTime PayedAt { set; get; } = DateTime.Now;
        [Required]
        [Range(0, 65535)]
        public decimal? Amount { set; get; }
        [Required]
        public int? AttendanceID { set; get; }

        [Required]
        public int? TraineeID { set; get; }

        [Required]
        public int? EventID { set; get; }
    }
}

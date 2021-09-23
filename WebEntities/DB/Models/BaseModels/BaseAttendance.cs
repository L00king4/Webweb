using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.DB.Models.BaseModels
{
    public class BaseAttendance : IBaseModel
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public virtual int TraineeID { set; get; }
        [Required]
        public virtual int EventID { set; get; }
    }
}

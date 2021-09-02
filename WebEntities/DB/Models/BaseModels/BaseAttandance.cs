using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.Models.BaseModels
{
    public class BaseAttandance
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public int? TraineeID { set; get; }
        [Required]
        public int? EventID { set; get; }
    }
}

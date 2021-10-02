using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Enums;

namespace WebEntities.DB.Models.BaseModels
{
    public class BaseTrainee : IBaseModel
    {
        [Key]
        public int ID { set; get; }
        [Required]
        [StringLength(50, MinimumLength = 4)]
        public virtual string Fullname { set; get; }
        [Required]
        public virtual AgeGroup AgeGroup { set; get; }
        public virtual DateTime? Birthday { set; get; }

        // Email, Phone, ...

        [Required]
        public virtual BeltColor BeltColor { set; get; }
    }
}

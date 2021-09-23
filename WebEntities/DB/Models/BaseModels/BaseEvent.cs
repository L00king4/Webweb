using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Enums;

namespace WebEntities.DB.Models.BaseModels
{
    public class BaseEvent : IBaseModel
    {
        [Key]
        public int ID { set; get; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        [Required]
        [Range(0, 4)]
        public virtual AgeGroup AgeGroup { set; get; }
        [Required]
        [Range(0, 2147483647)]
        public virtual decimal ToPay { set; get; }
        public virtual DateTime? Date { set; get; }
    }
}
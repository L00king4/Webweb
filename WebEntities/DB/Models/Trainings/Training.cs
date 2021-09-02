using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.Enums;
using WebEntities.DB.Models.BaseModels;

namespace WebEntities.Models.Trainings
{
    public class Training : BaseEvent
    {
        [Required]
        public new DateTime Date { set; get; }
        [Required]
        [Range(0, 4)]
        public AgeGroup AgeGroup { set; get; }
    }
}

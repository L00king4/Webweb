using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.BaseModels;
using WebEntities.Models.PayedEvents;

namespace WebEntities.Models.Competitions
{
    public class Competition : BaseEvent
    {
        [Required]
        public virtual DateTime Date { set; get; }
    }
}

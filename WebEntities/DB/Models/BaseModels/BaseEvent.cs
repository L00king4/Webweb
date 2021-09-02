using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.Models.BaseModels
{
    public class BaseEvent
    {
        [Key]
        public int ID { set; get; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Name { set; get; }
        public string Description { set; get; }
        [Required]
        [Range(0, 65535)]
        public decimal? ToPay { set; get; }
        public DateTime? Date { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace WebEntities.DB.Models.Interfaces
{
    public interface IBaseEvent : IBaseModel
    {
        public int ID { set; get; }
        public string? Name { set; get; }
        public string Description { set; get; }
        public decimal? ToPay { set; get; }
        public DateTime? Date { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WebEntities.Enums;

namespace WebEntities.DB.Models.Interfaces
{
    public interface IBaseTrainee
    {
        public int ID { set; get; }
        public string Fullname { set; get; }
        public byte? Age { set; get; }
        public AgeGroup AgeGroup { set; get; }
        public BeltColor? BeltColor { set; get; }
    }
}

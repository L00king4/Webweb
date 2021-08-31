//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace WebEntities.Db.Models
//{
//    public class Event
//    {
//        public int EventID { set; get; }
//        public string Name { set; get; }
//        public string? Description { set; get; }
//        public decimal ToPay { set; get; }
//        public DateTime Date { set; get; }
//        public EventType EventType { set; get; }
//        public ICollection<EventTrainee> EventTrainees { set; get; }
//        public ICollection<Payment> Payments { set; get; }
//    }

//    public enum EventType : byte { 
//        RegularTraining,
//        Competition,
//        Other
//    }
//}

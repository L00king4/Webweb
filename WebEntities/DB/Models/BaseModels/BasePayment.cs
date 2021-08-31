﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebEntities.DB.Models.Interfaces;

namespace WebEntities.Models.BaseModels
{
    public class BasePayment<TEvent, TAttendance> : IBasePayment
    {
        [Key]
        public int ID { set; get; }
        public DateTime PayedAt { set; get; } = DateTime.Now;
        [Required]
        [Range(0, 65535)]
        public decimal? Amount { set; get; }
        [Required]
        public int? AttendanceID { set; get; }
        private TAttendance Attendance { set; get; }

        [Required]
        public int? TraineeID { set; get; }
        private Trainee Trainee { set; get; }

        [Required]
        public int? EventID { set; get; }
        private TEvent Event { set; get; }
    }
}
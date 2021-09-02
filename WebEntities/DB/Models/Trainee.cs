﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Enums;
using WebEntities.Models.Competitions;
using WebEntities.Models.PayedEvents;
using WebEntities.Models.Trainings;

namespace WebEntities.Models
{
    public class Trainee : IBaseTrainee
    {
        [Key]
        public int ID { set; get; }
        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Fullname { set; get; }
        public byte? Age { set; get; }
        [Required]
        [Range(0, 4)]
        public AgeGroup AgeGroup { set; get; }

        // Email, Phone, ...

        [Range(0, 19)]
        public BeltColor? BeltColor { set; get; }
    }
}

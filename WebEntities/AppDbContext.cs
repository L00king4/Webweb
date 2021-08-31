using Microsoft.EntityFrameworkCore;
using System;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models;
using WebEntities.Models.Competitions;
using WebEntities.Models.PayedEvents;
using WebEntities.Models.Trainings;

namespace WebEntities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //public DbSet<Attendance> Attendances { set; get; }

        public DbSet<Competition> Competitions { set; get; } 
        public DbSet<CompetitionAttendance> CompetitionAttendances { set; get; } 
        public DbSet<CompetitionPayment> CompetitionPayments { set; get; }

        public DbSet<PayedEvent> PayedEvents { set; get; }
        public DbSet<PayedEventAttendance> PayedEventAttendances { set; get; }
        public DbSet<PayedEventPayment> PayedEventPayments { set; get; }

        public DbSet<Training> Trainings { set; get; }
        public DbSet<TrainingAttendance> TrainingAttendance { set; get; }
        public DbSet<TrainingPayment> TrainingPayments { set; get; }

        public DbSet<Trainee> Trainees { set; get; }
    }
}

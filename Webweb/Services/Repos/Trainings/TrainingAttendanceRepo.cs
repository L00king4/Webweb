using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEntities;
using WebEntities.Models.Trainings;
using Webweb.Services.Interfaces.Repos.Trainings;
using Webweb.Services.Repos.Base;

namespace Webweb.Services.Repos.Trainings
{
    public class TrainingAttendanceRepo : BaseAttendanceRepo<TrainingAttendance>, ITrainingAttendanceRepo
    {
        public TrainingAttendanceRepo(AppDbContext db) : base(db)
        {
        }
    }
}

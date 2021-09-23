using AutoMapper;
using System.Collections.Generic;
using WebEntities.DB.Models.Trainings;
using WebEntities.Models;
using WebEntities.Models.Trainings;
using Webweb.Models.Competitions;
using Webweb.Models.Trainings;

namespace Webweb.Models.Mappers.Profiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Trainee, SortedTraineePayment>();
            CreateMap<Training, TrainingInfo>();
            CreateMap<TrainingSpanPayment, TrainingPayedSpan>();
        }
    }
}

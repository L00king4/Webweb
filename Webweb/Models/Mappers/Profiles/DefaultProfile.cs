using AutoMapper;
using System.Collections.Generic;
using WebEntities.Models;
using Webweb.Models.Competitions;

namespace Webweb.Models.Mappers.Profiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Trainee, SortedTraineePayment>();
        }
    }
}

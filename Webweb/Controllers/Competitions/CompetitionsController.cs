using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebEntities.DB.Models.Interfaces;
using WebEntities.Models;
using WebEntities.Models.Competitions;
using Webweb.Addons;
using Webweb.Controllers.BaseControllers;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces;
using Webweb.Services.UnitsOfWork;

namespace Webweb.Controllers.Competitions
{
    //[Route("competitions")]
    public class CompetitionsController : BaseEventController<IUnitOfCompetition, Competition>
    {
        public CompetitionsController(IMapper mapper, IUnitOfCompetition unit, AllUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }


        //[HttpGet("")]
        //[HttpGet("all")]
        //public async Task<IEnumerable<Competition>> GetAllEvents()
        //{
        //    return await _unit.Events.GetAllAsync();
        //}


        [HttpGet("[controller]/{eventID}/trainees")]
        public async Task<SortedTrainees> GetAttendingTrainees(int eventID)
        {
            var attendances = await _unit.Attendances.WhereAsync(x => x.EventID == eventID);
            var trainees = await _unit.Trainees.GetAllAsync();

            var attendingTrainees = trainees.Where(
                x => attendances.Any(
                    y => y.TraineeID == x.ID
                )
            );
            var notAttendingTrainees = await Task.Run(() => trainees.Except(attendingTrainees));
            return new SortedTrainees()
            {
                AttendingTrainees = attendingTrainees.ToList(),
                NotAttendingTrainees = notAttendingTrainees.ToList()
            };
        }

        // 2000-10-10T11:12:12
    }
}

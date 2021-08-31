using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebEntities.Models;
using WebEntities.Models.Competitions;
using Webweb.Addons;
using Webweb.Models.Competitions;
using Webweb.Services.Interfaces;

namespace Webweb.Controllers
{
    //[Route("competitions")]
    public class CompetitionsController : BaseController<IUnitOfCompetition, Competition>
    {
        public CompetitionsController(IMapper mapper, IUnitOfCompetition unit, IUnitOfWork allunit) : base(mapper, unit, allunit)
        {
        }


        //[HttpGet("")]
        //[HttpGet("all")]
        //public async Task<IEnumerable<Competition>> GetAllEvents()
        //{
        //    return await _unit.Events.GetAllAsync();
        //}

        [HttpGet("{id}")]
        public async Task<Competition> GetEventByID(int id)
        {
            return await _unit.Events.FindAsync(id);
        }


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
